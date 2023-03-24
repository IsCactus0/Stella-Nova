using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Firefly : Bullet
    {
        public Firefly()
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y)
            : base(x, y)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy) :
            base(x, y, vx, vy)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Detail = 24;
            Thickness = 16f;
            Frequency = 0.01f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);

            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail)
        {
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.PapayaWhip;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness)
        {
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency)
        {
            TipColour = Color.White;
            BaseColour = Color.FromNonPremultiplied(232, 156, 1, 256);
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency, colour)
        {
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }
        public Firefly(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color tipcolour, Color baseColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency, tipcolour, baseColour)
        {
            ImpactSounds = new List<SoundEffect>()
            {
                SoundManager.PlasmaImpact0,
                SoundManager.PlasmaImpact1,
                SoundManager.PlasmaImpact2,
                SoundManager.PlasmaImpact3,
            };
        }

        public override void Destroy()
        {
            for (int i = 0; i < Main.random.Next(4, 8); i++)
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
                        0f, 10f, 0.05f,
                        2f + (float)Main.random.NextDouble(), TeamIndex - 1, Main.random.Next(32, 128),
                        Color.Black, Color.Black, Color.FromNonPremultiplied(232, 156, 1, 256) * 0.2f));
            }

            base.Destroy();
        }
        public override void Update(float delta)
        {
            float angle = (float)Main.openSimplexNoise.Evaluate(
                Position.X / 100f,
                Position.Y / 100f,
                Main.NoiseOffset) * MathHelper.TwoPi;

            if (TimeAlive != 0)
                Acceleration += new Vector2(
                    (float)Math.Cos(angle),
                    (float)Math.Sin(angle)) * 5000f * TimeAlive / MaxLifespan;

            if (Utility.CalculateChancePerSecond(delta, 0.001f))
                ParticleManager.particles.Add(
                    new Spark(
                        Polygon.Origin.X + ((float)Main.random.NextDouble() - 0.5f) * 6f,
                        Polygon.Origin.Y + ((float)Main.random.NextDouble() - 0.5f) * 6f,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f,
                        3f, TeamIndex - 1, 16,
                        Color.FromNonPremultiplied(69, 75, 18, 256), Color.FromNonPremultiplied(232, 156, 1, 256), Color.Black));
            
            if (Utility.CalculateChancePerSecond(delta, 0.003f))
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
                        2f + (float)Main.random.NextDouble(), TeamIndex - 1, Main.random.Next(32, 128),
                        Color.Black, Color.Black, Color.FromNonPremultiplied(232, 156, 1, 256) * 0.2f));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 24, (int)Position.Y - 24, 48, 48), Color.FromNonPremultiplied(232, 156, 1, 256));
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 12, (int)Position.Y - 12, 24, 24), Color.White);
        }

    }
}