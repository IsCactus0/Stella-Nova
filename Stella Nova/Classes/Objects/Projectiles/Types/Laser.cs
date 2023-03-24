using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Laser : Bullet
    {
        public Laser()
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y)
            : base(x, y)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail)
        {
            Detail = detail;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = frequency;
            TipColour = Color.White;
            BaseColour = Color.Turquoise;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency, colour)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = frequency;
            TipColour = colour;
            BaseColour = colour;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
        }
        public Laser(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color tipColour, Color baseColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency, tipColour, baseColour)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = frequency;
            TipColour = tipColour;
            BaseColour = baseColour;

            ImpactSounds = new List<SoundEffect>() {
                SoundManager.LaserImpact0,
                SoundManager.LaserImpact1,
                SoundManager.LaserImpact2,
                SoundManager.LaserImpact3,
                SoundManager.LaserImpact4,
            };
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
                        0f, 10f, 0.1f,
                        0.5f + (float)Main.random.NextDouble() / 5f, TeamIndex, Main.random.Next(2, 12),
                        Color.Green, Color.Aquamarine, Color.MediumSpringGreen));
            }

            base.Destroy();
        }
        public override void Update(float delta)
        {
            // if (Utility.CalculateChancePerSecond(delta, 100f))
            // ParticleManager.particles.Add(
            //     new Blur(
            //         Position.X,
            //         Position.Y,
            //         0f, 0f, 0f, 0f,
            //         (float)Main.random.NextDouble() - 0.5f,
            //         (float)Main.random.NextDouble() - 0.5f,
            //         0f, 10f, 1f, 0.05f + ((float)Main.random.NextDouble() / 20f), TeamIndex, 12,
            //         Color.FromNonPremultiplied(91, 91, 91, 255), Color.MediumSpringGreen));

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

            base.Draw(spriteBatch);

            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 16, (int)Position.Y - 16, 32, 32), Color.MediumSpringGreen);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 8, (int)Position.Y - 8, 16, 16), Color.White);
        }
    }
}