using Microsoft.Xna.Framework;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Particles.Types;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Singularity : Projectile
    {
        public Singularity()
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y)
            : base(x, y)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            BurnTime = 0.5f;
        }
        public Singularity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float burnTime)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            BurnTime = burnTime;
        }

        public float BurnTime;
        private float LastBurned;

        public override void FindCollisions()
        {
            List<Asteroid> asteroids = AsteroidManager.FindAll(Position, 600f);
            if (asteroids.Count > 0)
            {
                if (LastBurned >= BurnTime)
                    LastBurned = 0f;
                else return;

                for (int i = 0; i < asteroids.Count; i++)
                {
                    this.Penetration--;
                    this.TimeAlive = 0;

                    if (this.Penetration <= 0)
                        this.Destroy();

                    float distance = Vector2.Distance(Position, asteroids[i].Position) / 16f;
                    asteroids[i].Acceleration = 100000f * Vector2.Normalize(Position - asteroids[i].Position) / (distance * distance);
                    TimeAlive = 0;

                    float damage = Main.random.Next(MinDamage, MaxDamage + 1);
                    int finalDamage = (int)Math.Round(damage, 0);
                    bool isCrit = (float)Main.random.NextDouble() <= CritChance;
                    
                    if (isCrit)
                    {
                        finalDamage = (int)Math.Round(damage * CritBonus, 0);
                        ParticleManager.particles.Add(new ScoreIndicator(
                            asteroids[i].Position.X,
                            asteroids[i].Position.Y,
                            Velocity.X / 3f - ((float)Main.random.NextDouble() * 5f),
                            Velocity.Y / 3f - ((float)Main.random.NextDouble() * 5f),
                            0f, 0f,
                            (float)Main.random.NextDouble() * MathHelper.PiOver2 - MathHelper.PiOver4,
                            ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                            0f,
                            0f, 0.01f, 1.8f, finalDamage.ToString(), 0.15f + (finalDamage / (MaxDamage * CritBonus) / 10f),
                            Color.Lerp(Color.Crimson, Color.MediumVioletRed, finalDamage / (MaxDamage * CritBonus)), UIManager.Roboto_Medium));
                    }
                    else
                    {
                        ParticleManager.particles.Add(new ScoreIndicator(
                            asteroids[i].Position.X,
                            asteroids[i].Position.Y,
                            Velocity.X / 3f - ((float)Main.random.NextDouble() * 5f),
                            Velocity.Y / 3f - ((float)Main.random.NextDouble() * 5f),
                            0f,
                            0f,
                            (float)Main.random.NextDouble() * MathHelper.PiOver2 - MathHelper.PiOver4,
                            ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                            0f,
                            0f, 0.01f, 1.5f, finalDamage.ToString(), 0.1f + (damage / MaxDamage / 10f),
                            Color.Lerp(Color.MistyRose, Color.DarkOrange, damage / MaxDamage), UIManager.Roboto_Light));
                    }
                    
                    if (asteroids[i].Health - finalDamage <= 0)
                        asteroids[i].Health = 0f;
                    else asteroids[i].Health -= finalDamage;
                }
            }
        }
        public override void Update(float delta)
        {
            LastBurned += delta;

            base.Update(delta);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}