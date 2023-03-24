using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class CopperWarhead : Projectile
    {
        public CopperWarhead()
        {

        }
        public CopperWarhead(float x, float y)
            : base(x, y)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {

        }

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(8, 4);
        }
        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 0.5f))
            {
                for (int i = 0; i < 12; i++)
                {
                    Vector2 randomOffset = new Vector2(
                        (float)Main.random.NextDouble() * 12f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                        (float)Main.random.NextDouble() * 12f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                    ParticleManager.particles.Add(
                        new Spark(
                            Position.X + randomOffset.X,
                            Position.Y + randomOffset.Y,
                            randomOffset.X * 5f,
                            randomOffset.Y * 5f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.05f,
                            0.6f + (float)Main.random.NextDouble() / 5f, -1, Main.random.Next(12, 32),
                            Color.OrangeRed, Color.LightGoldenrodYellow, Color.Maroon));

                    ParticleManager.particles.Add(
                        new Smoke(
                            Position.X + randomOffset.X,
                            Position.Y + randomOffset.Y,
                            randomOffset.X * 5f,
                            randomOffset.Y * 5f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.05f,
                            3f + (float)Main.random.NextDouble() / 10f, -1, Main.random.Next(48, 64),
                            Color.Gray * 0.2f, Color.Black, 0.5f));
                }
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 12, (int)Position.Y - 12, 24, 24), Color.Chocolate * 1.2f);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 6, (int)Position.Y - 6, 12, 12), Color.White);

            // base.Draw(spriteBatch);
        }
    }
}