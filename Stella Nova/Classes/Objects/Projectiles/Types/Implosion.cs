using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Implosion : Projectile
    {
        public Implosion()
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y)
            : base(x, y)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = 256f;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 5f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float radius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = radius;
            MinRadius = 0f;
            Speed = 2000f;
            Strength = 1f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float radius, float minRadius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = radius;
            MinRadius = minRadius;
            Speed = 2000f;
            Strength = 1f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float radius, float minRadius, float speed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = radius;
            MinRadius = minRadius;
            Speed = speed;
            Strength = 1f;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }
        public Implosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float radius, float minRadius, float speed, float strength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Radius = radius;
            MinRadius = minRadius;
            Speed = speed;
            Strength = strength;
            MaxStrength = Strength;
            Mass = float.PositiveInfinity;
        }

        public float Radius;
        public float MinRadius;
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

            spaceObjects.Remove(this);

            for (int i = 0; i < spaceObjects.Count; i++)
            {
                if (spaceObjects[i].Mass <= 0 || spaceObjects[i].Mass >= float.PositiveInfinity)
                    continue;

                spaceObjects[i].Acceleration -= (spaceObjects[i].Position - Position) * Strength / spaceObjects[i].Mass;
            }
        }
        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(
                new Explosion(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 0f, 300, Color.Azure, Color.DodgerBlue, Color.MidnightBlue, Color.PowderBlue));

            base.Destroy();
        }
        public override void Update(float delta)
        {
            // Radius -= delta * Speed;
            // Strength = MaxStrength * (TimeAlive / MaxLifespan);

            // if (Radius <= MinRadius)
            //     this.Destroy();

            if (TimeAlive > MaxLifespan)
                this.Destroy();

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}