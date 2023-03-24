using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.Enemies;
using Stella_Nova.Classes.Objects.Enemies.Types;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Entities.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Managers
{
    public class EntityManager : DrawableGameComponent
    {
        public static SpriteBatch spriteBatch;
        public static List<Entity> entities;
        public static QuadTree quadTree;
        public EntityManager(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            entities = new List<Entity>();
            quadTree = new QuadTree(2, new Rectangle());
        }

        public override void Update(GameTime gameTime)
        {
            if (Main.isResetting || Main.GameSpeed <= 0 || Main.gameStage != Enums.GameStage.Playing)
                return;

            float delta = ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * Main.GameSpeed;
            if (entities.Count < 1 && Utility.CalculateChancePerSecond(delta, 0.02f))
            {
                Vector2 position = Utility.RandomAlongBorder(
                    Main.camera.RenderBoundingBox, 0, 0);
                entities.Add(new Wormhole(position.X, position.Y));
                // entities.Add(new Wraith(position.X, position.Y));
            }

            if (entities.Count > 0)
                quadTree = new QuadTree(6, Main.camera.RenderBoundingBox);

            for (int i = entities.Count - 1; i >= 0; i--)
                if (Utility.WithinBounds(entities[i], Main.camera, Main.PhysicsDistance))
                {
                    quadTree.Add(entities[i]);
                    entities[i].Update(delta);
                }
                else entities.RemoveAt(i);

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);
            for (int i = 0; i < entities.Count; i++)
                if (!(entities[i] is Blackhole || entities[i] is Omni))
                    if (Utility.WithinBounds(entities[i], Main.camera, Main.RenderDistance))
                        entities[i].Draw(spriteBatch);
            spriteBatch.End();

            // spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);
            // Main.AlphaClamp.CurrentTechnique.Passes[0].Apply();
            // foreach (Omni omni in entities.FindAll(x => x is Omni))
            //     if (Utility.WithinBounds(omni, Main.camera, Main.RenderDistance))
            //         omni.Draw(spriteBatch);
            // spriteBatch.End();

            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.NonPremultiplied, null, null, null, null, transformMatrix: Main.camera.Transform);
                foreach (Blackhole blackhole in entities.FindAll(x => x is Blackhole))
                    if (Utility.WithinBounds(blackhole, Main.camera, Main.RenderDistance))
                        blackhole.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public static SpaceObject FindNearest(Vector2 position, int teamIndex, float searchRadius = 1024f)
        {
            if (entities.Count == 0)
                return null;
            else if (entities.Count == 1 && entities[0].TeamIndex != teamIndex && Vector2.Distance(position, entities[0].Position) <= searchRadius)
                return entities[0];
            else
            {
                SpaceObject target = null;
                float dist;

                Rectangle searchBounds = new Rectangle(
                    (int)(position.X - searchRadius),
                    (int)(position.Y - searchRadius),
                    (int)(searchRadius * 2f),
                    (int)(searchRadius * 2f));

                foreach (Entity entity in FindAll(searchBounds))
                {
                    if (entity.TeamIndex == teamIndex)
                        continue;

                    dist = Vector2.Distance(position, entity.Position);
                    if (dist < searchRadius)
                    {
                        searchRadius = dist;
                        target = entity;
                    }
                }

                return target;
            }
        }
        public static List<Entity> FindAll(Rectangle bounds, bool ignoreImmuntiy = false)
        {
            return quadTree.Query(bounds).FindAll(x => !ignoreImmuntiy || x.TimeAlive > ((Entity)x).ImmunityPeriod)
                            .Cast<Entity>().ToList();
        }
        public static List<Entity> FindAll(SpaceObject spaceObject, bool ignoreImmuntiy = false)
        {
            return FindAll(spaceObject.Polygon.Rectangle, ignoreImmuntiy);
        }
        public static List<Entity> FindAll(Vector2 position, float searchRadius, bool ignoreImmuntiy = false)
        {
            Rectangle searchBounds = new Rectangle(
                (int)(position.X - searchRadius),
                (int)(position.Y - searchRadius),
                (int)(searchRadius * 2f),
                (int)(searchRadius * 2f));

            return quadTree.Query(searchBounds)
                            .FindAll(x => Vector2.Distance(x.Position, position) <= searchRadius &&
                            (!ignoreImmuntiy || x.TimeAlive > ((Entity)x).ImmunityPeriod))
                            .Cast<Entity>().ToList();
        }
    }
}