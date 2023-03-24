using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.Pickups;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Managers
{
    public class PickupManager : DrawableGameComponent
    {
        public static SpriteBatch spriteBatch;
        public static List<Pickup> pickups;
        public static QuadTree quadTree;

        public PickupManager(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            pickups = new List<Pickup>();
            quadTree = new QuadTree(2, new Rectangle());
        }

        public override void Update(GameTime gameTime)
        {
            if (Main.GameSpeed <= 0 || Main.gameStage == Enums.GameStage.Menu)
                return;

            if (pickups.Count > 0)
                quadTree = new QuadTree(6, Main.camera.RenderBoundingBox);

            float delta = ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * Main.GameSpeed;
            // if (Utility.CalculateChancePerSecond(delta, 0.01f))
            // {
            //     Vector2 position = Utility.RandomAlongBorder(
            //         new Rectangle(
            //             (int)PlayerManager.player.Position.X - 500,
            //             (int)PlayerManager.player.Position.Y - 500,
            //             1000,
            //             1000), 0, 0);
            //     pickups.Add(new ShieldPower(position.X, position.Y));
            // }

            for (int i = pickups.Count - 1; i >= 0; i--)
            if (Utility.WithinBounds(pickups[i], Main.camera, Main.PhysicsDistance))
            {
                quadTree.Add(pickups[i]);
                pickups[i].Update(delta);
            }
            else pickups.RemoveAt(i);

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);
            for (int i = 0; i < pickups.Count; i++)
                if (Utility.WithinBounds(pickups[i], Main.camera, Main.RenderDistance))
                    pickups[i].Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public static SpaceObject FindNearest(Vector2 position, float searchRadius = 1024f)
        {
            if (pickups.Count == 0)
                return null;
            else if (pickups.Count == 1 && Vector2.Distance(position, pickups[0].Position) <= searchRadius)
                return pickups[0];
            else
            {
                SpaceObject target = null;
                float dist;

                Rectangle searchBounds = new Rectangle(
                    (int)(position.X - searchRadius),
                    (int)(position.Y - searchRadius),
                    (int)(searchRadius * 2f),
                    (int)(searchRadius * 2f));

                foreach (Pickup pickup in FindAll(searchBounds))
                {
                    dist = Vector2.Distance(position, pickup.Position);
                    if (dist < searchRadius)
                    {
                        searchRadius = dist;
                        target = pickup;
                    }
                }

                return target;
            }
        }
        public static List<Pickup> FindAll(Rectangle bounds, bool ignoreImmuntiy = false)
        {
            return quadTree.Query(bounds).FindAll(x => !ignoreImmuntiy || x.TimeAlive > 0.3f)
                            .Cast<Pickup>().ToList();
        }
        public static List<Pickup> FindAll(SpaceObject spaceObject, bool ignoreImmuntiy = false)
        {
            return FindAll(spaceObject.Polygon.Rectangle, ignoreImmuntiy);
        }
        public static List<Pickup> FindAll(Vector2 position, float searchRadius, bool ignoreImmuntiy = false)
        {
            Rectangle searchBounds = new Rectangle(
                (int)(position.X - searchRadius),
                (int)(position.Y - searchRadius),
                (int)(searchRadius * 2f),
                (int)(searchRadius * 2f));

            return quadTree.Query(searchBounds)
                            .FindAll(x => Vector2.Distance(x.Position, position) <= searchRadius &&
                            (!ignoreImmuntiy || x.TimeAlive > 0.3f))
                            .Cast<Pickup>().ToList();
        }
    }
}