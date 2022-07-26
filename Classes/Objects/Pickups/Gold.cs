using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Pickups
{
    public class Gold : Pickup
    {
        public Gold()
        {
            Mass = 10f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());            
        }
        public Gold(float x, float y)
            : base(x, y)
        {
            Mass = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Gold(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Mass = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Mass = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Mass = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Mass = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Mass = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Asteroid(6, 3, 5f, Main.random.Next(3, 7), Main.openSimplexNoise, Main.random);
        }
        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 0.01f))
                ParticleManager.particles.Add(
                    new Blur(
                        Position.X,
                        Position.Y,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 1f, 0.4f + (float)Main.random.NextDouble() / 20f, 0, 20,
                        Color.SandyBrown,
                        Color.SaddleBrown));
            if (Utility.CalculateChancePerSecond(delta, 0.005f))
                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + Main.random.Next(-6, 6),
                        Position.Y + Main.random.Next(-6, 6),
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 1f, 0.02f, 0, 20,
                        Color.LightGoldenrodYellow,
                        Color.White,
                        Color.Gold));

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Color.FromNonPremultiplied(196, 156, 72, 255) * 1.2f, 3f);
        }
    }
}