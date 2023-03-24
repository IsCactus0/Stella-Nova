using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Shockwave : Projectile
    {
        public Shockwave()
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y)
            : base(x, y)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = 0f;
            MaxRadius = 256f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float maxRadius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = 0f;
            MaxRadius = maxRadius;
            Speed = 2000f;
            Strength = 1f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float maxRadius, float speed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = 0f;
            MaxRadius = maxRadius;
            Speed = speed;
            Strength = 1f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Shockwave(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float maxRadius, float speed, float strength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = 0f;
            MaxRadius = maxRadius;
            Speed = speed;
            Strength = strength;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }

        public float Radius;
        public float MaxRadius;
        public float Speed;
        public float Strength;
        public float MaxStrength;

        public override void FindCollisions()
        {
            List<SpaceObject> spaceObjects = AsteroidManager.FindAll(Position, Radius)
                        .Concat<SpaceObject>(EntityManager.FindAll(Position, Radius))
                        .Concat<SpaceObject>(ProjectileManager.FindAll(Position, Radius))
                        .Concat<SpaceObject>(ParticleManager.FindAll(Position, Radius)).ToList();

            if (Vector2.Distance(PlayerManager.player.Position, Position) <= Radius)
                spaceObjects.Add(PlayerManager.player);

            for (int i = 0; i < spaceObjects.Count; i++)
            {
                if (spaceObjects[i].Mass > 0)
                    spaceObjects[i].Acceleration += (spaceObjects[i].Position - Position) * Strength / spaceObjects[i].Mass;
            }
        }
        public override void Update(float delta)
        {
            Radius += delta * Speed;
            if (Radius >= MaxRadius)
                this.Destroy();

            Strength = MaxStrength * (1f - Radius / MaxRadius);

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            // Drawing.DrawLine(spriteBatch,
            //     new Vector2(Position.X - Radius, Position.Y),
            //     new Vector2(Position.X + Radius, Position.Y),
            //     Color.White, Radius * 2f);

            spriteBatch.Draw(Main.circle, new Rectangle(
                (int)(Position.X - Radius),
                (int)(Position.Y - Radius),
                (int)(Radius * 2f),
                (int)(Radius * 2f)), Color.Gainsboro * 0.2f * (1f - Radius / MaxRadius));

            // base.Draw(spriteBatch);
        }
    }
}