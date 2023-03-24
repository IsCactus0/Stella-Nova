using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Missile : HomingProjectile
    {
        public Missile()
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Missile(float x, float y)
            : base(x, y)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            TurnSpeed = 1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            TurnSpeed = 30f;
            TrackingStrength = 2000f;
            Friction = 0.3f;
            MaxLifespan = 16f;
            isFaulty = Main.random.NextDouble() < 0.1f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength)
        {
            TurnSpeed = 1f;
            MaxLifespan = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange)
        {
            TurnSpeed = 1f;
            MaxLifespan = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Missile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange, SpaceObject target)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange, target)
        {
            TurnSpeed = 0.2f;
            MaxLifespan = 10f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public bool isFaulty;
        public float TurnSpeed;
        
        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>()
            {
                new Vector2(-5.0f,   -2.5f) * 1.5f,
                new Vector2( 5.0f,   -2.5f) * 1.5f,
                new Vector2( 7.0f,   -1.5f) * 1.5f,
                new Vector2( 8.5f,    0.0f) * 1.5f,
                new Vector2( 7.0f,    1.5f) * 1.5f,
                new Vector2( 5.0f,    2.5f) * 1.5f,
                new Vector2(-5.0f,    2.5f) * 1.5f,
            };
        }
        public override void FindCollisions()
        {
            List<Entity> entities = AsteroidManager.FindAll(Polygon.Rectangle).Cast<Entity>()
                .Concat(EntityManager.FindAll(Polygon.Rectangle)).ToList();

            if (TeamIndex != PlayerManager.player.TeamIndex && PlayerManager.player.Polygon.Rectangle.Intersects(Polygon.Rectangle))
                entities.Add(PlayerManager.player);

            if (entities.Count > 0)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    if (entities[i].TeamIndex == TeamIndex)
                        continue;

                    Destroy();
                    return;
                }
            }
        }
        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(
                new Explosion(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 0f, 128));

            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (TimeAlive < MaxLifespan / 2f && TimeAlive > MaxLifespan / 12f)
            {
                Vector3 currentlyFacing = new Vector3((float)Math.Cos(Angle), (float)Math.Sin(Angle), 0);
                if (isFaulty)
                {
                    AngularVelocity = TurnSpeed * delta * ((float)Main.random.NextDouble() - 0.5f) * 200f;
                    if (Utility.CalculateChancePerSecond(delta, 0.005f))
                        Destroy();
                }
                else if (!(Target is null))
                {
                    Vector2 towardsTarget = Target.Position - Position;
                    Vector3 towardsTarget3 = new Vector3(towardsTarget, 0f);
                    float crossProductSign = Vector3.Cross(currentlyFacing, towardsTarget3).Z;
                    
                    if (crossProductSign < 0)
                        AngularVelocity -= TurnSpeed * delta;
                    else if (crossProductSign > 0)
                        AngularVelocity += TurnSpeed * delta;
                }


                if (Utility.CalculateChancePerSecond(delta, 5f * (1f - TimeAlive / (MaxLifespan / 2f))))
                {
                    Acceleration += new Vector2(currentlyFacing.X, currentlyFacing.Y) * TrackingStrength;

                    ParticleManager.particles.Add(
                        new Spark(
                            Position.X - (float)Math.Cos(Angle) * 8f,
                            Position.Y - (float)Math.Sin(Angle) * 8f,
                            (float)Math.Cos(Angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * -200f,
                            (float)Math.Sin(Angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * -200f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.05f,
                            0.6f + (float)Main.random.NextDouble() / 5f, TeamIndex, Main.random.Next(12, 32),
                            Color.OrangeRed, Color.LightGoldenrodYellow, Color.Maroon));

                    ParticleManager.particles.Add(
                        new Smoke(
                            Position.X - (float)Math.Cos(Angle) * 8f,
                            Position.Y - (float)Math.Sin(Angle) * 8f,
                            (float)Math.Cos(Angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * -200f,
                            (float)Math.Sin(Angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * -200f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.05f,
                            3f + (float)Main.random.NextDouble() / 10f, TeamIndex, Main.random.Next(48, 64),
                            Color.Gray * 0.2f, Color.Black, 0.5f));
                }
            }
            else Target = null;
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {            
            Polygon.DrawWithLighting(spriteBatch, Color.White, 2f);
        }
    }
}