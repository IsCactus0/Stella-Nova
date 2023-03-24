using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Entities
{
    public class Entity : SpaceObject
    {
        public Entity()
            : base()
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y)
            : base(x, y)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = -1;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = teamIndex;
            Health = 100f;
            MaxHealth = 100f;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = teamIndex;
            Health = health;
            MaxHealth = health;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = teamIndex;
            Health = health;
            MaxHealth = maxHealth;
            ImmunityPeriod = 0.02f;
        }
        public Entity(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = teamIndex;
            Health = health;
            MaxHealth = maxHealth;
            ImmunityPeriod = immunityPeriod;
        }

        public int TeamIndex;
        public float Health;
        public float MaxHealth;
        public float ImmunityPeriod;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(32f, 8f);
        }
        public override void FindCollisions()
        {
            // foreach (Asteroid asteroid in AsteroidManager.FindAll(this))
            // {
            //     if (Health <= 0)
            //     {
            //         this.Destroy();
            //         break;
            //     }
            // 
            //     AsteroidManager.Destroy(asteroid);
            //     Health -= asteroid.Radius / 10;
            //     Velocity *= 1f - asteroid.Radius / 64;
            // }
        }
        public override void Destroy()
        {
            Position.X -= Main.PhysicsDistance * 2f;
            EntityManager.entities.Remove(this);
        }
        public virtual void Heal(int health, int minHealth, int maxHealth, float critBonus, bool isCrit)
        {
            Health += health;
            if (Health > MaxHealth)
                Health = MaxHealth;

            ParticleManager.particles.Add(new Indicator(
                Position.X - (((float)Main.random.NextDouble() - 0.5f) * 35f),
                Position.Y - (((float)Main.random.NextDouble() - 0.5f) * 35f),
                Velocity.X - (((float)Main.random.NextDouble() - 0.5f) * 5f),
                Velocity.Y - (((float)Main.random.NextDouble() - 0.5f) * 5f),
                0f, 0f,
                ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                0f,
                float.PositiveInfinity, 0.01f, 3f, health.ToString(), 0.15f + (health / (maxHealth * critBonus) / 10f),
                Color.Lerp(Color.SpringGreen, Color.ForestGreen, Utility.Map(health, minHealth * critBonus, maxHealth * critBonus, 0, 1)), UIManager.Roboto_Medium));
        }
        public virtual void Damage(int damage, int minDamage, int maxDamage, float critBonus, bool isCrit, int teamIndex, Vector2 impact)
        {
            if (TimeAlive <= ImmunityPeriod)
            {
                TimeAlive = 0;
                return;
            }

            if (TeamIndex == teamIndex)
                return;

            TimeAlive = 0;
            Health -= damage;

            if (TeamIndex != PlayerManager.player.TeamIndex)
            {
                if (isCrit)
                {
                    ParticleManager.particles.Add(new ScoreIndicator(
                        impact.X,
                        impact.Y,
                        Velocity.X - ((float)Main.random.NextDouble() * 5f),
                        Velocity.Y - ((float)Main.random.NextDouble() * 5f),
                        0f, 0f,
                        ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                        ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                        0f,
                        float.PositiveInfinity, 0.01f, 10f, damage.ToString(), 0.3f + (damage / (maxDamage * critBonus) / 10f),
                        Color.Lerp(
                            Color.FromNonPremultiplied(232, 156, 1, 256),
                            Color.FromNonPremultiplied(221, 64, 9, 256),
                            Utility.Map(damage, minDamage * critBonus, maxDamage * critBonus, 0, 1)), UIManager.Roboto_Medium));
                }
                else
                {
                    ParticleManager.particles.Add(new ScoreIndicator(
                        impact.X,
                        impact.Y,
                        Velocity.X - ((float)Main.random.NextDouble() * 5f),
                        Velocity.Y - ((float)Main.random.NextDouble() * 5f),
                        0f,
                        0f,
                        (float)Main.random.NextDouble() * MathHelper.PiOver2 - MathHelper.PiOver4,
                        ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                        0f,
                        float.PositiveInfinity, 0.01f, 10f, damage.ToString(), 0.25f + (damage / maxDamage / 10f),
                        Color.Lerp(Color.LightYellow, Color.Orange, (float)damage / maxDamage), UIManager.Roboto_Light));
                }
            }
            // else
            // {
            //     if (isCrit)
            //     {
            //         ParticleManager.particles.Add(new Indicator(
            //             impact.X,
            //             impact.Y,
            //             Velocity.X - ((float)Main.random.NextDouble() * 5f),
            //             Velocity.Y - ((float)Main.random.NextDouble() * 5f),
            //             0f, 0f,
            //             ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
            //             ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
            //             0f,
            //             float.PositiveInfinity, 0.01f, 10f, damage.ToString(), 0.3f + (damage / (maxDamage * critBonus) / 10f),
            //             Color.Lerp(Color.Crimson, Color.DarkViolet, Utility.Map(damage, minDamage * critBonus, maxDamage * critBonus, 0, 1)), Main.Roboto_Medium));
            //     }
            //     else
            //     {
            //         ParticleManager.particles.Add(new Indicator(
            //             impact.X,
            //             impact.Y,
            //             Velocity.X - ((float)Main.random.NextDouble() * 5f),
            //             Velocity.Y - ((float)Main.random.NextDouble() * 5f),
            //             0f,
            //             0f,
            //             (float)Main.random.NextDouble() * MathHelper.PiOver2 - MathHelper.PiOver4,
            //             ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
            //             0f,
            //             float.PositiveInfinity, 0.01f, 10f, damage.ToString(), 0.25f + (damage / maxDamage / 10f),
            //             Color.Lerp(Color.MistyRose, Color.Orange, (float)damage / maxDamage), Main.Roboto_Light));
            //     }
            // }
            
        }
        public override void Update(float delta)
        {
            if (Health <= 0)
                this.Destroy();

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Color.White);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}