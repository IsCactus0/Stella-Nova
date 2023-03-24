using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Bullet : Projectile
    {
        public Bullet()
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(Vector2.Zero, Detail).ToList();
        }
        public Bullet(float x, float y)
            : base(x, y)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = 12;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = detail;
            Thickness = 8f;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Transparent;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = 0.02f;
            TipColour = Color.White;
            BaseColour = Color.Transparent;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = frequency;
            TipColour = Color.White;
            BaseColour = Color.Black;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = frequency;
            TipColour = colour;
            BaseColour = colour;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }
        public Bullet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, int detail, float trailThickness, float frequency, Color tipColour, Color baseColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Detail = detail;
            Thickness = trailThickness;
            Frequency = frequency;
            TipColour = tipColour;
            BaseColour = baseColour;
            Trail = Enumerable.Repeat(new Vector2(x, y), Detail).ToList();
        }

        public List<Vector2> Trail;
        public int Detail;
        public float Thickness;
        public float Frequency;
        public Color TipColour;
        public Color BaseColour;

        protected float lastAdded;

        public override void Update(float delta)
        {
            lastAdded += delta;
            // Check if the trail should be updated...
            if (lastAdded > Frequency)
            {
                // Loop over every segment that should have been updated since the last update call...
                for (int i = 0; i < Math.Floor(lastAdded / Frequency); i++)
                {
                    Trail.Add(Position);
                    if (Trail.Count > Detail)
                        Trail.RemoveAt(0);
                }

                // Then reset the timer.
                lastAdded = 0f;
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
        }
        public override SpaceObject Clone()
        {
            return (Bullet)MemberwiseClone();
        }
    }
}