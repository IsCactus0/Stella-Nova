using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using System;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Plasma : HomingProjectile
    {
        public Plasma()
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y)
            : base(x, y)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage, critChance)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange, SpaceObject target)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange, target)
        {
            ExplosionRadius = 100f;
        }
        public Plasma(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange, SpaceObject target, float explosionRadius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange, target)
        {
            ExplosionRadius = explosionRadius;
        }

        public float ExplosionRadius;

        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(new Explosion(this.Position.X, this.Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, int.MaxValue, 128, 256, 0.3f, 2.3f));
            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (Utilities.Utility.CalculateChancePerSecond(delta, 1f))
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 24f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * 24f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));
            
                ParticleManager.particles.Add(
                new Spark(
                    Position.X + randomOffset.X / 5f,
                    Position.Y + randomOffset.Y / 5f,
                    randomOffset.X * 2f,
                    randomOffset.Y * 2f,
                    0f, 0f,
                    (float)Main.random.NextDouble() - 0.5f,
                    (float)Main.random.NextDouble() - 0.5f,
                    0f, 10f, 0.75f, 0.1f + (float)Main.random.NextDouble() / 5f, TeamIndex, 4,
                    Color.Black, Color.PeachPuff, Color.MidnightBlue));
            
                ParticleManager.particles.Add(
                    new Blur(
                        Position.X, Position.Y,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.7f, 0.1f, TeamIndex, 24,
                        Color.White, Color.RoyalBlue));
            }                    
            
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 21, (int)Position.Y - 21, 42, 42), Color.Violet * 1.2f);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 6, (int)Position.Y - 6, 12, 12), Color.White);
            // base.Draw(spriteBatch);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}