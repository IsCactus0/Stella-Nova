using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Utilities;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public abstract class HomingProjectile : Projectile
    {
        public HomingProjectile()
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y)
            : base(x, y)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            TrackingStrength = 100f;
            TrackingRange = 1500f;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            TrackingStrength = trackingStrength;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            TrackingStrength = trackingStrength;
            TrackingRange = trackingRange;
        }
        public HomingProjectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange, SpaceObject target)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            TrackingStrength = trackingStrength;
            TrackingRange = trackingRange;
            Target = target;
        }

        public float TrackingStrength;
        public float TrackingRange;
        public SpaceObject Target;

        public override void Update(float delta)
        {
            if (Target is null && TeamIndex != PlayerManager.player.TeamIndex && Vector2.Distance(PlayerManager.player.Position, Position) <= TrackingRange)
                Target = PlayerManager.player;
            if (Target is null)
                Target = EntityManager.FindNearest(Position, TeamIndex, TrackingRange);
            if (Target is null)
                Target = AsteroidManager.FindNearest(Position, TrackingRange);

            if (!(Target is null) && Vector2.Distance(Target.Position, this.Position) > TrackingRange)
                Target = null;

            base.Update(delta);
        }
        public override SpaceObject Clone()
        {
            return (HomingProjectile)MemberwiseClone();
        }
    }
}