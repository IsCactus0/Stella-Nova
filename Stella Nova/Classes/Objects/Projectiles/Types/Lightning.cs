using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Lightning : HomingProjectile
    {
        public Lightning()
        {
            ArmLength = 16;
            SegmentCount = 24;
            ArcSpeed = 0.01f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y)
            : base(x, y)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ArmLength = 48;
            SegmentCount = 24;
            ArcSpeed = 0.001f;
            Arms = new List<Vector2>();
            elapsedTime = ArcSpeed;
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
            elapsedTime = ArcSpeed;
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
            elapsedTime = ArcSpeed;
        }
        public Lightning(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange, SpaceObject target)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange, target)
        {
            ArmLength = 8;
            SegmentCount = 12;
            ArcSpeed = 0.02f;
            Arms = new List<Vector2>();
            elapsedTime = ArcSpeed;
        }

        public int ArmLength;
        public int SegmentCount;
        public float ArcSpeed;
        public List<Vector2> Arms;

        private float elapsedTime;

        public override void Update(float delta)
        {
            elapsedTime += delta;
            if (elapsedTime >= ArcSpeed)
            {
                elapsedTime = 0f;
                if (Arms.Count == SegmentCount)
                    Arms.RemoveAt(0);

                Arms.Add(Position + new Vector2(
                    Velocity.X + ((float)Main.random.NextDouble() - 0.5f),
                    Velocity.Y + ((float)Main.random.NextDouble() - 0.5f)) * ArmLength);
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            float strength;
            for (int i = 0; i < Arms.Count - 1; i++)
            {
                strength = (float)Math.Sin(((float)i / Arms.Count) * MathHelper.Pi);
                Drawing.DrawLine(spriteBatch, Arms[i], Arms[i + 1], Color.RoyalBlue * strength * 0.85f, 5 * strength);
                Drawing.DrawLine(spriteBatch, Arms[i], Arms[i + 1], Color.Plum * strength * 0.6f, 2 * strength);
            }
        }
    }
}