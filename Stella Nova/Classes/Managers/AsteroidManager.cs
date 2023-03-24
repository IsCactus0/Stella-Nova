using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Managers
{
    public class AsteroidManager : DrawableGameComponent
    {
        public static SpriteBatch spriteBatch;
        public static List<Asteroid> asteroids;
        public static QuadTree quadTree;

        public AsteroidManager(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            asteroids = new List<Asteroid>();
            quadTree = new QuadTree(4, new Rectangle());
        }

        public override void Update(GameTime gameTime)
        {
            if (Main.isResetting || Main.GameSpeed <= 0)
                return;

            if (asteroids.Count > 0)
                quadTree = new QuadTree(4, Main.camera.RenderBoundingBox);
            
            float delta = ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * Main.GameSpeed;
            if (asteroids.Count <= 12 / Main.camera.Scale)
                SpawnAsteroid(2, 6);            

            for (int i = asteroids.Count - 1; i >= 0 ; i--)
            {
                if (Utility.WithinBounds(asteroids[i], Main.camera, Main.PhysicsDistance))
                {
                    quadTree.Add(asteroids[i]);
                    asteroids[i].Update(delta);
                }
                else asteroids.RemoveAt(i);
            }            

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, SamplerState.PointClamp, DepthStencilState.None, RasterizerState.CullNone, null, transformMatrix: Main.camera.Transform);

            foreach (Asteroid asteroid in Utility.WithinBounds(quadTree, Main.camera, Main.RenderDistance))
                asteroid.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
        public static void Destroy(Asteroid asteroid)
        {
            asteroids.Remove(asteroid);
            asteroid.Destroy();
        }

        public static void SpawnAsteroid(int minScale, int maxScale)
        {
            int scale = Main.random.Next(minScale, maxScale);
            float radius = Main.random.Next(8, 20) * scale;

            Rectangle bounds = Main.camera.BoundingBox;

            Asteroid asteroid;
            if (Main.random.Next(20) == 0)
            {
                asteroid = new Comet(
                    bounds.X, bounds.Y,
                    (float)(Main.random.NextDouble() - 0.5f) * 2000f,
                    (float)(Main.random.NextDouble() - 0.5f) * 2000f,
                    0f, 0f,
                    0f, (float)Main.random.NextDouble() * 2f,
                    0f,                        // Mass
                    radius, 1f,                // Friction
                    radius / 2f,               // Health
                    radius / 2f,               // Max Health
                    radius,                    // Radius
                    5 * maxScale / scale + 25, // Detail
                    8f,                        // Roughness
                    (int)(radius / 3f));       // Resolution
            }
            else
                asteroid = new Asteroid(
                    bounds.X, bounds.Y,
                    (float)(Main.random.NextDouble() - 0.5f) * 100f,
                    (float)(Main.random.NextDouble() - 0.5f) * 100f,
                    0f, 0f,
                    0f, (float)Main.random.NextDouble() * 2f,
                    0f,                        // Mass
                    radius, 1f,                // Friction
                    radius / 2f,               // Health
                    radius / 2f,               // Max Health
                    radius,                    // Radius
                    5 * maxScale / scale + 48, // Detail
                    8f,                        // Roughness
                    (int)(radius / 3f));       // Resolution

            asteroid.Position = Utility.RandomAlongBorder(Main.camera.BoundingBox, asteroid.Polygon, Main.RenderDistance);
            asteroids.Add(asteroid);
        }
        public static List<Asteroid> SplitSimple(Asteroid asteroid)
        {
            List<Asteroid> asteroids = new List<Asteroid>();

            int count = Main.random.Next(2, 6);
            for (int i = 0; i < count; i++)
            {
                Vector2 randomOffset = new Vector2(
                    asteroid.Radius * (float)Math.Cos(Main.random.NextDouble() * MathHelper.TwoPi),
                    asteroid.Radius * (float)Math.Sin(Main.random.NextDouble() * MathHelper.TwoPi));

                asteroids.Add(new Asteroid(
                    asteroid.Position.X + randomOffset.X,
                    asteroid.Position.Y + randomOffset.Y,
                    asteroid.Velocity.X + randomOffset.X,
                    asteroid.Velocity.Y + randomOffset.Y,
                    asteroid.Acceleration.X * (float)(Main.random.NextDouble() - 0.5f),
                    asteroid.Acceleration.Y * (float)(Main.random.NextDouble() - 0.5f),
                    (float)Main.random.NextDouble() - 0.5f, (float)Main.random.NextDouble() - 0.5f, 0f,
                    (asteroid.Mass / count) * 0.8f, 1f, asteroid.Radius / 2f, asteroid.Radius / 2f,
                    asteroid.Radius / count,
                    asteroid.Detail,
                    MathHelper.Clamp(asteroid.Detail / count, 3, 5)));
            }

            return asteroids;
        }
        public static void BooleanCut(Vector2 impact, Asteroid asteroid)
        {
            // Assuming asteroid radius is >= 50.
            List<Vector3> originalVertices = new List<Vector3>(asteroid.Polygon.OriginalVertices);
            List<Vector3> cutVertices = new List<Vector3>();
            List<Vector3> addedVertices = new List<Vector3>();

            float maxDist = asteroid.Radius / 2f;
            float distance;
            Vector2 direction;
            Vector2 relative;

            // Find all the vertices of the original asteroid which should be cut.
            for (int i = 0; i < originalVertices.Count; i++)
            {
                relative = asteroid.Position - impact;
                direction = Utility.VectorXY(originalVertices[i]); 
                distance = (relative - direction).Length();

                if (distance > maxDist)
                    continue;

                direction.Normalize();
                direction *= 300f / (distance * distance);
                originalVertices[i] += new Vector3(direction, 0f);
            }

            asteroid.Polygon.OriginalVertices = originalVertices;
        }

        public static SpaceObject FindNearest(Vector2 position, float searchRadius = 1024f)
        {
            if (asteroids.Count == 0)
                return null;
            else if (asteroids.Count == 1 && Vector2.Distance(position, asteroids[0].Position) <= searchRadius)
                return asteroids[0];
            else
            {
                SpaceObject target = null;
                float dist;

                Rectangle searchBounds = new Rectangle(
                    (int)(position.X - searchRadius),
                    (int)(position.Y - searchRadius),
                    (int)(searchRadius * 2f),
                    (int)(searchRadius * 2f));

                foreach (Asteroid asteroid in FindAll(searchBounds))
                {
                    dist = Vector2.Distance(position, asteroid.Position);
                    if (dist < searchRadius)
                    {
                        searchRadius = dist;
                        target = asteroid;
                    }
                }

                return target;
            }
        }
        public static SpaceObject FindNearest(List<SpaceObject> asteroids, Vector2 position, float searchRadius = 1024f)
        {
            if (asteroids.Count == 0)
                return null;
            else if (asteroids.Count == 1 && Vector2.Distance(position, asteroids[0].Position) <= searchRadius)
                return asteroids[0];
            else
            {
                Asteroid target = null;
                float dist;

                Rectangle searchBounds = new Rectangle(
                    (int)(position.X - searchRadius),
                    (int)(position.Y - searchRadius),
                    (int)(searchRadius * 2f),
                    (int)(searchRadius * 2f));

                foreach (Asteroid asteroid in FindAll(searchBounds))
                {
                    dist = Vector2.Distance(position, asteroid.Position);
                    if (dist < searchRadius)
                    {
                        searchRadius = dist;
                        target = asteroid;
                    }
                }

                return target;
            }
        }
        public static List<Asteroid> FindAll(Rectangle bounds, bool ignoreImmuntiy = false)
        {
            return quadTree.Query(bounds).FindAll(x => !ignoreImmuntiy || x.TimeAlive > ((Entity)x).ImmunityPeriod)
                            .Cast<Asteroid>().ToList();
        }
        public static List<Asteroid> FindAll(SpaceObject spaceObject, bool ignoreImmuntiy = false)
        {
            return FindAll(spaceObject.Polygon.Rectangle, ignoreImmuntiy);
        }
        public static List<Asteroid> FindAll(Vector2 position, float searchRadius, bool ignoreImmuntiy = false)
        {
            Rectangle searchBounds = new Rectangle(
                (int)(position.X - searchRadius),
                (int)(position.Y - searchRadius),
                (int)(searchRadius * 2f),
                (int)(searchRadius * 2f));

            return quadTree.Query(searchBounds)
                            .FindAll(x => Vector2.Distance(x.Position, position) <= searchRadius + ((Asteroid)x).Radius &&
                            (!ignoreImmuntiy || x.TimeAlive > ((Entity)x).ImmunityPeriod))
                            .Cast<Asteroid>().ToList();
        }
    }
}