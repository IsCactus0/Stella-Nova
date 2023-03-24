using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Objects.Pickups.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Asteroids
{
    public class Asteroid : Entity
    {
        public Asteroid()
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Mass = Radius * 100f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Asteroid(float x, float y)
            : base(x, y)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Mass = Radius * 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Mass = Radius * 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Mass = Radius * 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Mass = Radius * 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Mass = Radius * 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Mass = Radius * 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Radius = 32;
            Detail = Radius / 1.5f;
            Roughness = Detail / Radius;
            Resolution = 1;
            Health = Radius;
            MaxHealth = Health;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, -1)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = Radius;
            MaxHealth = Health;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, -1, health)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = health;
            MaxHealth = health;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, -1, health, maxHealth)
        {
            Radius = 32;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Health = health;
            MaxHealth = maxHealth;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, -1, health, maxHealth)
        {
            Radius = radius;
            Detail = 1;
            Roughness = Detail / radius;
            Resolution = (int)(radius / 1.5f);
            Health = health;
            MaxHealth = maxHealth;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius, float detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, -1, health, maxHealth)
        {
            Radius = radius;
            Detail = detail;
            Roughness = detail / radius;
            Resolution = (int)(radius / 1.5f);
            Health = health;
            MaxHealth = maxHealth;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius, float detail, float roughness)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, -1, health, maxHealth)
        {
            Radius = radius;
            Detail = detail;
            Roughness = roughness;
            Resolution = (int)(radius / 1.5f);
            Health = health;
            MaxHealth = maxHealth;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Asteroid(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius, float detail, float roughness, int resolution)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, -1, health, maxHealth)
        {
            Radius = radius;
            Detail = detail;
            Roughness = roughness;
            Resolution = resolution;
            Health = health;
            MaxHealth = maxHealth;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public float Radius;
        public float Detail;
        public float Roughness;
        public int Resolution;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Asteroid(Radius, Detail, Roughness, Resolution, Main.openSimplexNoise, Main.random);
        }
        public override void FindCollisions()
        {
            List<Asteroid> asteroids = AsteroidManager.FindAll(Position, Radius);
            asteroids.Remove(this);
            
            if (asteroids.Count == 0)
                return;

            float overlap;
            float distance;
            Vector2 direction;
            Vector2 normal;
            Vector2 tangental;

            for (int i = 0; i < asteroids.Count; i++)
            {
                // Find direction and distance.
                direction = Position - asteroids[i].Position;
                distance = direction.Length();
                normal = direction / distance;

                // Calculate overlap.
                overlap = 0.5f * (distance - asteroids[i].Radius - this.Radius);

                // Displace by overlap.
                this.Position -= overlap * normal;
                asteroids[i].Position += overlap * normal;

                // Tangental.
                tangental.X = -1f * normal.Y;
                tangental.Y = normal.X;

                // Dot product tangental.
                float dpTan1 = Velocity.X * tangental.X + Velocity.Y * tangental.Y;
                float dpTan2 = asteroids[i].Velocity.X * tangental.X + asteroids[i].Velocity.Y * tangental.Y;

                // Dot product normal.
                float dpNorm1 = Velocity.X * normal.X + Velocity.Y * normal.Y;
                float dpNorm2 = asteroids[i].Velocity.X * normal.X + asteroids[i].Velocity.Y * normal.Y;

                // Conservation of momentum in 1D.
                float m1 = (dpNorm1 * (Mass - asteroids[i].Mass) + 2.0f * asteroids[i].Mass * dpNorm2) / (Mass + asteroids[i].Mass);
                float m2 = (dpNorm2 * (asteroids[i].Mass - Mass) + 2.0f * Mass * dpNorm1) / (Mass + asteroids[i].Mass);

                Velocity = tangental * dpTan1 + normal * m1;
                asteroids[i].Velocity = tangental * dpTan2 + normal * m2;

                Vector2 difference = Velocity - asteroids[i].Velocity;
                float force = difference.Length();

                int damage;
                if (force > 30000f)
                {
                    damage = (int)(Math.Clamp(force - 30000f, 0f, 1000f) / 100f);
                    if (damage > 0)
                    {
                        asteroids[i].Damage(damage, 0, 1000, 0, false, TeamIndex, Position + normal * Radius);
                        Damage(damage, 0, 1000, 0, false, asteroids[i].TeamIndex, Position + normal * asteroids[i].Radius * -1f);
                    }
                }
            }
        }
        public override void Damage(int damage, int minDamage, int maxDamage, float critBonus, bool isCrit, int teamIndex, Vector2 impact)
        {
            for (int i = 0; i < (Resolution / 8f) * (damage / maxDamage); i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Math.Cos(Main.random.NextDouble() * MathHelper.TwoPi),
                    (float)Math.Sin(Main.random.NextDouble() * MathHelper.TwoPi));
                randomOffset *= Radius / 4f;

                if (Radius > 24)
                    ParticleManager.particles.Add(
                        new AsteroidDebris(
                            impact.X,
                            impact.Y,
                            Velocity.X + ((impact.X + randomOffset.X) - Position.X),
                            Velocity.Y + ((impact.Y + randomOffset.Y) - Position.Y),
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 1f, 1f + (float)Main.random.NextDouble(),
                            teamIndex, Main.random.Next(2, 9), 1.1f, 4, 5,
                            Color.PowderBlue, Color.PowderBlue, Color.SteelBlue));
                
                ParticleManager.particles.Add(
                    new Blur(
                        impact.X,
                        impact.Y,
                        Velocity.X,
                        Velocity.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 0.1f, 1f + (float)Main.random.NextDouble(), teamIndex,
                        Main.random.Next(24, 64),
                        Color.DimGray, Color.Black));
            }

            base.Damage(damage, minDamage, maxDamage, critBonus, isCrit, teamIndex, impact);
        }
        public override void Destroy()
        {
            if (Radius > 48)
                foreach (Asteroid asteroid in AsteroidManager.SplitSimple(this))
                    AsteroidManager.asteroids.Add(asteroid);

            for (int i = 0; i < Resolution / 4f; i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * Radius * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * Radius * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                if (Radius > 24)
                    ParticleManager.particles.Add(
                        new AsteroidDebris(
                            Position.X + randomOffset.X,
                            Position.Y + randomOffset.Y,
                            Velocity.X + randomOffset.X * 3f,
                            Velocity.Y + randomOffset.Y * 3f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 1f, 6f + (float)Main.random.NextDouble(),
                            TeamIndex, Main.random.Next(4, 12), 1.1f, 4, 4,
                            Color.PowderBlue, Color.PowderBlue, Color.SteelBlue));

                ParticleManager.particles.Add(
                    new Blur(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        Velocity.X + randomOffset.X,
                        Velocity.Y + randomOffset.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 0.1f, 1f + (float)Main.random.NextDouble(),
                        TeamIndex, Main.random.Next(24, 64),
                        Color.DimGray, Color.Black));
            }

            if (Radius > 16 && Main.random.Next(3) == 0)
            {
                for (int i = 0; i < Main.random.Next(2, 5); i++)
                {
                    Vector2 randomOffset = new Vector2(
                        (float)Main.random.NextDouble() * Radius * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                        (float)Main.random.NextDouble() * Radius * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));
            
                    switch (Main.random.Next(3))
                    {
                        case 0:
                            PickupManager.pickups.Add(
                            new Iron(
                                Position.X + randomOffset.X,
                                Position.Y + randomOffset.Y,
                                Velocity.X + randomOffset.X,
                                Velocity.Y + randomOffset.Y,
                                0f, 0f,
                                (float)Main.random.NextDouble() * MathHelper.TwoPi, (float)Main.random.NextDouble() * 2f, 0f,
                                1f, 0.2f));
                            break;
                        case 1:
                            PickupManager.pickups.Add(
                            new Nickel(
                                Position.X + randomOffset.X,
                                Position.Y + randomOffset.Y,
                                Velocity.X + randomOffset.X,
                                Velocity.Y + randomOffset.Y,
                                0f, 0f, 0f, 0f, 0f,
                                1f, 0.2f));
                            break;
                        case 2:
                            PickupManager.pickups.Add(
                            new Cobalt(
                                Position.X + randomOffset.X,
                                Position.Y + randomOffset.Y,
                                Velocity.X + randomOffset.X,
                                Velocity.Y + randomOffset.Y,
                                0f, 0f, 0f, 0f, 0f,
                                1f, 0.2f));
                            break;
                    }
                }
            }

            AsteroidManager.asteroids.Remove(this);
            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (Health <= 0)
                AsteroidManager.Destroy(this);

            if (Radius > 30f && Utility.CalculateChancePerSecond(delta, 0.005f))
            {
                float angle = (float)(Main.random.NextDouble() * MathHelper.TwoPi);
                Vector2 randomOffset = new Vector2(
                    Radius * (float)Math.Cos(angle),
                    Radius * (float)Math.Sin(angle));

                if (Radius > 24)
                    ParticleManager.particles.Add(
                        new AsteroidDebris(
                            Position.X + randomOffset.X * 1.2f,
                            Position.Y + randomOffset.Y * 1.2f,
                            Velocity.X + (float)(Main.random.NextDouble() - 0.5f) * 50f,
                            Velocity.Y + (float)(Main.random.NextDouble() - 0.5f) * 50f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 1f, 6f + (float)Main.random.NextDouble(),
                            TeamIndex, Main.random.Next(1, 7), 1.1f, 4, 4,
                            Color.PowderBlue, Color.PowderBlue, Color.SteelBlue));

                ParticleManager.particles.Add(
                    new Blur(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        Velocity.X + randomOffset.X,
                        Velocity.Y + randomOffset.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 0.1f, 1f + (float)Main.random.NextDouble(), TeamIndex,
                        Main.random.Next(12, 24),
                        Color.DimGray, Color.Black));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.DrawWithLighting(spriteBatch, Color.PowderBlue, 6f);

            // int detail = (int)Radius / 4;
            // for (int i = 0; i < detail; i++)
            // {
            //     float angle = MathHelper.TwoPi / detail;
            //     Drawing.DrawLine(spriteBatch,
            //         new Vector2(
            //             Position.X + (float)Math.Cos(angle * i) * Radius,
            //             Position.Y + (float)Math.Sin(angle * i) * Radius),
            //         new Vector2(
            //             Position.X + (float)Math.Cos(angle * (i + 1)) * Radius,
            //             Position.Y + (float)Math.Sin(angle * (i + 1)) * Radius),
            //         Color.Red, 3f);
            // }
            // 
            // string text = Mass.ToString();
            // Vector2 textSize = Main.Roboto_Light.MeasureString(text) * (Radius / 100f);
            // 
            // 
            // spriteBatch.DrawString(
            //     Main.Roboto_Light, text,
            //     new Vector2(Position.X - textSize.X / 2f, Position.Y - textSize.Y / 2f),
            //     Color.Red, 0f, Vector2.Zero, Radius / 100f, SpriteEffects.None, 0);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}