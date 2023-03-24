using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Tentacle : Rope
    {
        public Tentacle()
        {

        }
        public Tentacle(float x, float y)
            : base(x, y)
        {

        }
        public Tentacle(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public Tentacle(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public Tentacle(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public Tentacle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public Tentacle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public Tentacle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public Tentacle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public override void Update(float delta)
        {
            float noise = (float)Main.openSimplexNoise.Evaluate(Position.X, Position.Y, Main.NoiseOffset * 10f);
            Vector2 dir = new Vector2((float)Math.Cos(noise * MathHelper.TwoPi), (float)Math.Sin(noise * MathHelper.TwoPi));
            Segments.Follow(Position + dir * Segments.Joints.Count * Segments.SegmentLength, delta * noise);

            float fade = CalculateFade();
            if (Utility.CalculateChancePerSecond(delta, 0.2f * fade))
            {
                for (int i = 0; i < 16; i++)
                {
                    Vector2 randomOffset = new Vector2(
                        (float)Main.random.NextDouble() * 2f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                        (float)Main.random.NextDouble() * 2f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));


                    ParticleManager.particles.Add(
                        new Smoke(
                            Position.X + randomOffset.X,
                            Position.Y + randomOffset.Y,
                            randomOffset.X * 5f,
                            randomOffset.Y * 5f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.1f,
                            2f + (float)Main.random.NextDouble(), TeamIndex, Main.random.Next(12, 32),
                            Color.MediumOrchid * 0.2f * fade, Color.Navy * 0.1f * fade, 0.2f));
                }
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 1; i < Segments.Joints.Count; i++)
            {
                float thickness = (float)Math.Sin((i - 1f) / Segments.Joints.Count * MathHelper.Pi) * Segments.EndThickness + Segments.StartThickness;
                Color colour = Color.Lerp(Segments.BaseColour, Segments.TipColour, (float)i / Segments.Joints.Count);
                colour = Color.Lerp(Color.Transparent, colour, CalculateFade());
                Drawing.DrawLine(spriteBatch, Segments.Joints[i - 1].Position, Segments.Joints[i].Position, colour * 0.5f, thickness * 1.4f);
                Drawing.DrawLine(spriteBatch, Segments.Joints[i - 1].Position, Segments.Joints[i].Position, colour, thickness * 0.5f);
            }
        }
    }
}
