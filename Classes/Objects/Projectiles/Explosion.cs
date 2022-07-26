using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public class Explosion : Projectile
    {
        public Explosion()
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(Projectile projectile)
            : base(projectile)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y)
            : base(x, y)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;            
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;            
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;            
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;            
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;            
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;            
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;        
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;            
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = 100f;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float explosionRadius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = explosionRadius;
        }

        public float ExplosionRadius;

        public override void FindCollisions()
        {
            List<SpaceObject> spaceObjects = AsteroidManager.FindAll(Position, ExplosionRadius)
                .Concat<SpaceObject>(EntityManager.FindAll(this.Position, ExplosionRadius))
                .Concat<SpaceObject>(ProjectileManager.FindAll(this.Position, ExplosionRadius)).ToList();
            
            if (Vector2.Distance(PlayerManager.player.Position, this.Position) <= ExplosionRadius)
                spaceObjects.Add(PlayerManager.player);

            if (spaceObjects.Count == 0)
                return;

            for (int i = 0; i < spaceObjects.Count; i++)
            {
                if (spaceObjects[i] is Entity)
                {
                    float damage = Main.random.Next(MinDamage, MaxDamage + 1);
                    bool isCrit = (float)Main.random.NextDouble() <= CritChance;
                    int finalDamage = (int)Math.Round(damage * (isCrit ? CritBonus : 1), 0);

                    ((Entity)spaceObjects[i]).Damage(finalDamage, MinDamage, MaxDamage, CritBonus, isCrit, TeamIndex, spaceObjects[i].Position);
                }
            }

            this.Destroy();
        }
        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(
                new Shockwave(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, float.PositiveInfinity, 0f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 20, ExplosionRadius * 4f, 2000f, 10f));

            for (int i = 0; i < ExplosionRadius + Main.random.Next(16); i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * ExplosionRadius / 2f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * ExplosionRadius / 2f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));
            
                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        randomOffset.X * 5f,
                        randomOffset.Y * 5f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 0.1f,
                        1f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(2, 12),
                        Color.Gold, Color.Maroon, Color.Black));
            
                if (i % 4 == 0)
                    ParticleManager.particles.Add(
                        new Smoke(
                            Position.X - randomOffset.X,
                            Position.Y - randomOffset.Y,
                            -randomOffset.X,
                            -randomOffset.Y,
                            0f, 0f,
                            ((float)Main.random.NextDouble() - 0.5f) * 10f,
                            ((float)Main.random.NextDouble() - 0.5f) * 10f,
                            0f, 0.1f, 0.2f,
                            0.3f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(48, 128),
                            Color.Peru, Color.Maroon));
            
                if (Main.random.Next(6) == 0)
                {
                    ParticleManager.particles.Add(
                        new Spark(
                            Position.X,
                            Position.Y,
                            randomOffset.X * -10f * Main.random.Next(1, 4),
                            randomOffset.Y * -10f * Main.random.Next(1, 4),
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 0.5f, 0.1f,
                            1f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(2, 12),
                            Color.White, Color.Gold, Color.Maroon));
                }
            }

            for (int i = 0; i < Main.random.Next(1, 4); i++)
            {
                float randomAngle = (float)Main.random.NextDouble() * MathHelper.TwoPi;
                ProjectileManager.projectiles.Add(
                    new Shrapnel(
                        Position.X, Position.Y,
                        (float)Math.Cos(randomAngle) * 2000f,
                        (float)Math.Sin(randomAngle) * 2000f,
                        0f, 0f,
                        0f, 0f, 0f,
                        10f, 1f, TeamIndex, 2, 15, 23, 1.8f, 1.4f, 0.05f + ((float)Main.random.NextDouble() / 4f)));
            }

            base.Destroy();
        }
        public override void Update(float delta)
        {
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}