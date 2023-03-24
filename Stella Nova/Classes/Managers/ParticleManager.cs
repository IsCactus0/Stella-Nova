using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Managers
{
    public class ParticleManager : DrawableGameComponent
    {
        public static SpriteBatch spriteBatch;
        public static List<Particle> particles;
        public static QuadTree quadTree;

        private int maxParticles;

        public ParticleManager(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            particles = new List<Particle>();
            quadTree = new QuadTree(4, new Rectangle());

            maxParticles = 6000;
        }
        public override void Update(GameTime gameTime)
        {
            if (Main.isResetting || Main.GameSpeed <= 0)
                return;

            if (particles.Count > 0)
                quadTree = new QuadTree(48, Main.camera.RenderBoundingBox);

            float delta = ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * Main.GameSpeed;

            if (particles.Count > maxParticles)
                for (int i = 0; i < particles.Count - maxParticles; i++)
                    particles.RemoveAt(i);

            for (int i = particles.Count - 1; i >= 0; i--)
            {
                if (particles[i] is ScoreIndicator || Utility.WithinBounds(particles[i], Main.camera, Main.PhysicsDistance))
                {
                    quadTree.Add(particles[i]);
                    particles[i].Update(delta);
                }
                else particles.RemoveAt(i);
            }

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);

            for (int i = 0; i < particles.Count; i++)
                if (Utility.WithinBounds(particles[i], Main.camera, Main.RenderDistance))
                    particles[i].Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public static SpaceObject FindNearest(Vector2 position, float searchRadius = 1024f)
        {
            if (particles.Count == 0)
                return null;
            else if (particles.Count == 1 && Vector2.Distance(position, particles[0].Position) <= searchRadius)
                return particles[0];
            else
            {
                SpaceObject target = null;
                float dist;

                Rectangle searchBounds = new Rectangle(
                    (int)(position.X - searchRadius),
                    (int)(position.Y - searchRadius),
                    (int)(searchRadius * 2f),
                    (int)(searchRadius * 2f));

                foreach (Particle particle in FindAll(searchBounds))
                {
                    dist = Vector2.Distance(position, particle.Position);
                    if (dist < searchRadius)
                    {
                        searchRadius = dist;
                        target = particle;
                    }
                }

                return target;
            }
        }
        public static List<Particle> FindAll(Rectangle bounds, bool ignoreImmuntiy = false)
        {
            return quadTree.Query(bounds).FindAll(x => !ignoreImmuntiy || x.TimeAlive > 0.3f)
                            .Cast<Particle>().ToList();
        }
        public static List<Particle> FindAll(SpaceObject spaceObject, bool ignoreImmuntiy = false)
        {
            return FindAll(spaceObject.Polygon.Rectangle, ignoreImmuntiy);
        }
        public static List<Particle> FindAll(Vector2 position, float searchRadius, bool ignoreImmuntiy = false)
        {
            Rectangle searchBounds = new Rectangle(
                (int)(position.X - searchRadius),
                (int)(position.Y - searchRadius),
                (int)(searchRadius * 2f),
                (int)(searchRadius * 2f));

            return quadTree.Query(searchBounds)
                            .FindAll(x => Vector2.Distance(x.Position, position) <= searchRadius &&
                            (!ignoreImmuntiy || x.TimeAlive > 0.3f))
                            .Cast<Particle>().ToList();
        }
    }
}