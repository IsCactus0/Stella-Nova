using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Particles.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Explosion : Projectile
    {
        public Explosion()
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y)
            : base(x, y)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            MaxLifespan = 0f;
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = 100f;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float explosionRadius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = explosionRadius;
            Colour = Color.Gold;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float explosionRadius, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = explosionRadius;
            Colour = colour;
            EmberColour = Color.Maroon;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float explosionRadius, Color colour, Color emberColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = explosionRadius;
            Colour = colour;
            EmberColour = emberColour;
            FadeColour = Color.Black;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float explosionRadius, Color colour, Color emberColour, Color fadeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = explosionRadius;
            Colour = colour;
            EmberColour = emberColour;
            FadeColour = fadeColour;
            SmokeColour = Color.Peru;
        }
        public Explosion(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float explosionRadius, Color colour, Color emberColour, Color fadeColour, Color smokeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            ExplosionRadius = explosionRadius;
            Colour = colour;
            EmberColour = emberColour;
            FadeColour = fadeColour;
            SmokeColour = smokeColour;
        }

        public float ExplosionRadius;
        public Color Colour;
        public Color EmberColour;
        public Color FadeColour;
        public Color SmokeColour;

        public override void FindCollisions()
        {
            List<SpaceObject> spaceObjects = AsteroidManager.FindAll(Position, ExplosionRadius)
                        .Concat<SpaceObject>(EntityManager.FindAll(Position, ExplosionRadius)).ToList();

            if (Vector2.Distance(PlayerManager.player.Position, Position) <= ExplosionRadius)
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

            Destroy();
        }
        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(
                new Shockwave(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, float.PositiveInfinity, 1f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 20f, ExplosionRadius / 2f, 2000f, ExplosionRadius / 2f));

            Vector2 randomOffset;
            for (int i = 0; i < ExplosionRadius * 2f + Main.random.Next(16); i++)
            {
                randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * ExplosionRadius / 2f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * ExplosionRadius / 2f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X,
                        Position.Y,
                        randomOffset.X * 10f,
                        randomOffset.Y * 10f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f,
                        1f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(2, 12),
                        Colour, EmberColour, FadeColour));
            
                if (i % 4 == 0)
                    ParticleManager.particles.Add(
                        new Smoke(
                            Position.X,
                            Position.Y,
                            randomOffset.X * 10f,
                            randomOffset.Y * 10f,
                            0f, 0f,
                            ((float)Main.random.NextDouble() - 0.5f) * 10f,
                            ((float)Main.random.NextDouble() - 0.5f) * 10f,
                            0f, 10f, 0.2f,
                            0.3f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(48, 128),
                            SmokeColour, EmberColour));
            
                if (Main.random.Next(6) == 0)
                {
                    ParticleManager.particles.Add(
                        new Spark(
                            Position.X + randomOffset.X,
                            Position.Y + randomOffset.Y,
                            randomOffset.X * -10f * Main.random.Next(1, 4),
                            randomOffset.Y * -10f * Main.random.Next(1, 4),
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.1f,
                            4f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(2, 12),
                            SmokeColour, Colour, EmberColour));
                }
            }

            // for (int i = 0; i < Main.random.Next(1, 4); i++)
            // {
            //     float randomAngle = (float)Main.random.NextDouble() * MathHelper.TwoPi;
            //     ProjectileManager.projectiles.Add(
            //         new Shrapnel(
            //             Position.X, Position.Y,
            //             (float)Math.Cos(randomAngle) * 1000f,
            //             (float)Math.Sin(randomAngle) * 1000f,
            //             0f, 0f,
            //             0f, 0f,
            //             0f, 10f, 0.1f, TeamIndex, 10, 15, 23, 1.8f, 1.4f, 0.25f + ((float)Main.random.NextDouble() / 4f), 16, 12f, 0.02f, SmokeColour * 2f, EmberColour));
            // }

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