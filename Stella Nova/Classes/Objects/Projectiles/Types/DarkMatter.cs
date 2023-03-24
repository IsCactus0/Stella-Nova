using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class DarkMatter : Bullet
    {
        public DarkMatter()
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y)
            : base(x, y)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Black;
            BaseColour = Color.MediumPurple;
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.005f;
            TipColour = Color.MidnightBlue;
            BaseColour = Color.MediumPurple;
        }

        public override void Update(float delta)
        {
            this.Acceleration.X += 200f * (float)Math.Sin(TimeAlive * 5f + Main.NoiseOffset);
            this.Acceleration.Y += 200f * (float)Math.Sin(TimeAlive * 5f + Main.NoiseOffset);

            if (Utility.CalculateChancePerSecond(delta, 15f * (1f - TimeAlive / MaxLifespan)))
            {
                ParticleManager.particles.Add(
                    new Spark(
                        Polygon.Origin.X + ((float)Main.random.NextDouble() - 0.5f) * 2f,
                        Polygon.Origin.Y + ((float)Main.random.NextDouble() - 0.5f) * 2f,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f, 0.05f + (float)Main.random.NextDouble() / 5f, TeamIndex, 12, 
                        Color.Violet * 1.2f, Color.White, Color.MediumOrchid * 1.2f));

                ParticleManager.particles.Add(
                    new Smoke(
                        Polygon.Origin.X,
                        Polygon.Origin.Y,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f, 0.2f + (float)Main.random.NextDouble() / 2f, TeamIndex, 32,
                        Color.DarkSlateBlue * 0.4f, Color.Black * 0.4f));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 12, (int)Position.Y - 12, 24, 24), Color.MediumPurple * 1.2f);
            spriteBatch.Draw(Main.cloud, new Rectangle((int)Position.X - 12, (int)Position.Y - 12, 24, 24), Color.MediumPurple * 1.2f);
            spriteBatch.Draw(Main.cloud, new Rectangle((int)Position.X - 6, (int)Position.Y - 6, 12, 12), Color.Violet);
        }
    }
}