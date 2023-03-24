using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.Projectiles;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Managers
{
    public class ProjectileManager : DrawableGameComponent
    {
        public static SpriteBatch spriteBatch;
        public static List<Projectile> projectiles;
        public static QuadTree quadTree;

        public ProjectileManager(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            projectiles = new List<Projectile>();
            quadTree = new QuadTree(6, new Rectangle());
        }

        public override void Update(GameTime gameTime)
        {
            if (Main.isResetting || Main.GameSpeed <= 0)
                return;

            if (projectiles.Count > 0)
                quadTree = new QuadTree(24, Main.camera.RenderBoundingBox);

            float delta = ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * Main.GameSpeed;
            for (int i = projectiles.Count - 1; i >= 0; i--)
                if (Utility.WithinBounds(projectiles[i], Main.camera, Main.PhysicsDistance))
                {
                    quadTree.Add(projectiles[i]);
                    projectiles[i].Update(delta);
                }
                else projectiles.RemoveAt(i);

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);
            for (int i = 0; i < projectiles.Count; i++)
                if (Utility.WithinBounds(projectiles[i], Main.camera, Main.RenderDistance))
                    projectiles[i].Draw(spriteBatch);
            spriteBatch.End();

            // spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);
            // quadTree.Draw(spriteBatch);
            // spriteBatch.End();

            base.Draw(gameTime);
        }

        public static SpaceObject FindNearest(Vector2 position, float searchRadius = 1024f)
        {
            if (projectiles.Count == 0)
                return null;
            else if (projectiles.Count == 1 && Vector2.Distance(position, projectiles[0].Position) <= searchRadius)
                return projectiles[0];
            else
            {
                SpaceObject target = null;
                float dist;

                Rectangle searchBounds = new Rectangle(
                    (int)(position.X - searchRadius),
                    (int)(position.Y - searchRadius),
                    (int)(searchRadius * 2f),
                    (int)(searchRadius * 2f));

                foreach (Projectile projectile in FindAll(searchBounds))
                {
                    dist = Vector2.Distance(position, projectile.Position);
                    if (dist < searchRadius)
                    {
                        searchRadius = dist;
                        target = projectile;
                    }
                }

                return target;
            }
        }
        public static List<Projectile> FindAll(Rectangle bounds, bool ignoreImmuntiy = false)
        {
            return quadTree.Query(bounds).FindAll(x => !ignoreImmuntiy || x.TimeAlive > 0.3f)
                            .Cast<Projectile>().ToList();
        }
        public static List<Projectile> FindAll(SpaceObject spaceObject, bool ignoreImmuntiy = false)
        {
            return FindAll(spaceObject.Polygon.Rectangle, ignoreImmuntiy);
        }
        public static List<Projectile> FindAll(Vector2 position, float searchRadius, bool ignoreImmuntiy = false)
        {
            Rectangle searchBounds = new Rectangle(
                (int)(position.X - searchRadius),
                (int)(position.Y - searchRadius),
                (int)(searchRadius * 2f),
                (int)(searchRadius * 2f));

            return quadTree.Query(searchBounds)
                            .FindAll(x => Vector2.Distance(x.Position, position) <= searchRadius &&
                            (!ignoreImmuntiy || x.TimeAlive > 0.3f))
                            .Cast<Projectile>().ToList();
        }
    }
}