using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Utilities;
using System;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public class Bullet : Projectile
    {
        public Bullet()
        {

        }
        public Bullet(Projectile projectile) 
            : base(projectile)
        {

        }
        public Bullet(float x, float y)
            : base(x, y)
        {

        }
        public Bullet(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {

        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {

        }

        public override void Destroy()
        {
            for (int i = 0; i < Main.random.Next(100, 128); i++)
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
                        0f, 0.1f, 0.1f,
                        1f + (float)Main.random.NextDouble(), TeamIndex, Main.random.Next(2, 12),
                        Color.White, Color.Orange, Color.DarkSlateBlue));
            }

            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 30f))
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 5f * (float)Math.Cos(Main.random.NextDouble() * MathHelper.TwoPi),
                    (float)Main.random.NextDouble() * 5f * (float)Math.Sin(Main.random.NextDouble() * MathHelper.TwoPi));

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + randomOffset.X / 8f,
                        Position.Y + randomOffset.Y / 8f,
                        randomOffset.X,
                        randomOffset.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 3f, 0.75f, 0.6f + (float)Main.random.NextDouble() / 3f, TeamIndex, 8,
                        Color.White, Color.DeepSkyBlue, Color.Indigo));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            // Draw Trail
            // for (int i = MathHelper.Clamp((int)(TimeAlive * 50f), 0, 12); i >= 0; i--)
            // {
            //     Drawing.DrawLine(spriteBatch,
            //         Position - (Velocity * (i / 100f)),
            //         Position - (Velocity * ((i + 1) / 100f)),
            //         Color.Indigo * (1f - (i / 10f)), (12f - i));
            //     Drawing.DrawLine(spriteBatch,
            //         Position - (Velocity * (i / 100f)),
            //         Position - (Velocity * ((i + 1) / 100f)),
            //         Color.White * (1f - (i / 10f)), (12f - i) / 2f);
            // }

            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 16, (int)Position.Y - 16, 32, 32), Color.Indigo);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 8, (int)Position.Y - 8, 16, 16), Color.White);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}