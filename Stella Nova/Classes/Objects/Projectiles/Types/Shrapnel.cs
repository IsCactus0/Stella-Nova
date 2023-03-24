using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Shrapnel : Bullet
    {
        public Shrapnel()
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y)
            : base(x, y)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y, float vx, float vy) :
            base(x, y, vx, vy)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
            Friction = 0.1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Coral;
            BaseColour = Color.DarkOrange;
            MaxLifespan = 1f;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = 16;
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.Coral * 2f;
            BaseColour = Color.Maroon;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail)
        {
            Thickness = 12f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness)
        {
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency)
        {
            TipColour = Color.White;
            BaseColour = Color.DarkOrange;
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency, colour)
        {
        }
        public Shrapnel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color tipcolour, Color baseColour)
         : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, detail, trailThickness, frequency, tipcolour, baseColour)
        {

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

            if (Utility.CalculateChancePerSecond(delta, 0.5f))
            {
                ParticleManager.particles.Add(
                    new Spark(
                        Polygon.Origin.X + ((float)Main.random.NextDouble() - 0.5f) * 6f,
                        Polygon.Origin.Y + ((float)Main.random.NextDouble() - 0.5f) * 6f,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f,
                        0.5f, TeamIndex, 16,
                        BaseColour, BaseColour * 2f, Color.Black, 0.2f));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < Trail.Count; i++)
            {
                if (i < Trail.Count - 1)
                    Drawing.DrawLine(spriteBatch,
                        Trail[i],
                        Trail[i + 1],
                        Color.Lerp(TipColour, BaseColour, 1f - (float)i / Trail.Count),
                        Thickness * ((float)i / Trail.Count));
                else
                    Drawing.DrawLine(spriteBatch,
                        Trail[i],
                        Position,
                        TipColour,
                        Thickness * ((float)i / Trail.Count));
            }

            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 24, (int)Position.Y - 24, 48, 48), BaseColour * 2f);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 12, (int)Position.Y - 12, 24, 24), TipColour);            
        }    
    }
}