using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public class Laser : Projectile
    {
        public Laser()
        {
        }
        public Laser(Projectile projectile)
            : base(projectile)
        {

        }
        public Laser(float x, float y)
            : base(x, y)
        {
        }
        public Laser(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {

        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {

        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {

        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {

        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {

        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {

        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {

        }

        public override List<Vector2> GenerateShape()
        {
            return base.GenerateShape();
        }
        public override void Destroy()
        {
            for (int i = 0; i < Main.random.Next(32, 48); i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 32f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * 32f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        randomOffset.X * 5f,
                        randomOffset.Y * 5f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 3f, 0.9f,
                        0.2f + (float)Main.random.NextDouble() / 10f, TeamIndex, Main.random.Next(2, 12),
                        Color.Green, Color.Aquamarine, Color.MediumSpringGreen));
            }

            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 100f))
            ParticleManager.particles.Add(
                new Blur(
                    Position.X,
                    Position.Y,
                    0f, 0f, 0f, 0f,
                    (float)Main.random.NextDouble() - 0.5f,
                    (float)Main.random.NextDouble() - 0.5f,
                    0f, 0.1f,
                    1f,
                    0.05f + ((float)Main.random.NextDouble() / 20f), TeamIndex,
                    12,
                    Color.SeaGreen,
                    Color.MediumSpringGreen));

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //// Draw Trail
            //for (int i = MathHelper.Clamp((int)(TimeAlive * 200f), 0, 8); i >= 0; i--)
            //{
            //    Drawing.DrawLine(spriteBatch,
            //        Position - (Velocity * (i / 300f)),
            //        Position - (Velocity * ((i + 1) / 300f)),
            //        Color.RoyalBlue * (1f - (i / 10f)), (10f - i) / 2f);
            //    Drawing.DrawLine(spriteBatch,
            //        Position - (Velocity * (i / 300f)),
            //        Position - (Velocity * ((i + 1) / 300f)),
            //        Color.White * (1f - (i / 10f)), (10f - i) / 4f);
            //}

            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 16, (int)Position.Y - 16, 32, 32), Color.MediumSpringGreen);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 8, (int)Position.Y - 8, 16, 16), Color.White);
        }
    }
}