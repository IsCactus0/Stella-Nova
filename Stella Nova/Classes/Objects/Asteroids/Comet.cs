using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Objects.Pickups.Types;
using System;

namespace Stella_Nova.Classes.Objects.Asteroids
{
    public class Comet : Asteroid
    {
        public Comet()
        {

        }
        public Comet(Asteroid asteroid)
        {
            Polygon = asteroid.Polygon;
            Position = asteroid.Position;
            Velocity = asteroid.Velocity;
            Acceleration = asteroid.Acceleration;
            Angle = asteroid.Angle;
            AngularVelocity = asteroid.AngularVelocity;
            AngularAcceloration = asteroid.AngularAcceloration;
            Mass = asteroid.Mass;
            Friction = asteroid.Friction;
            TimeAlive = asteroid.TimeAlive;
        }
        public Comet(float x, float y)
            : base(x, y)
        {

        }
        public Comet(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, health)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, health, maxHealth)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, health, maxHealth, radius)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius, float detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, health, maxHealth, radius, detail)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius, float detail, float roughness)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, health, maxHealth, radius, detail, roughness)
        {

        }
        public Comet(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float health, float maxHealth, float radius, float detail, float roughness, int resolution)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, health, maxHealth, radius, detail, roughness, resolution)
        {

        }

        public override void Destroy()
        {
            if (Radius > 48)
                foreach (Asteroid asteroid in AsteroidManager.SplitSimple(this))
                    AsteroidManager.asteroids.Add(new Comet(asteroid));

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
                            0f, 3f, 1f, 1f + (float)Main.random.NextDouble(),
                            Main.random.Next(5, 12), 1.1f, 4, TeamIndex, 12,
                            Color.MediumTurquoise, Color.MediumTurquoise, Color.SteelBlue));

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
                        TeamIndex,
                        Main.random.Next(24, 64),
                        Color.MediumTurquoise, Color.Black));
            }

            if (Radius > 16)
            {
                for (int i = 0; i < Radius / 32; i++)
                {
                    Vector2 randomOffset = new Vector2(
                        (float)Main.random.NextDouble() * Radius * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                        (float)Main.random.NextDouble() * Radius * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                    PickupManager.pickups.Add(
                    new Ice(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        Velocity.X + randomOffset.X,
                        Velocity.Y + randomOffset.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() * MathHelper.TwoPi, (float)Main.random.NextDouble() * 2f, 0f,
                        1f, 0.2f));
                }
            }

            AsteroidManager.asteroids.Remove(this);
        }
        public override void Damage(int damage, int minDamage, int maxDamage, float critBonus, bool isCrit, int teamIndex, Vector2 impact)
        {
            for (int i = 0; i < Resolution / 8f; i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Math.Cos(Main.random.NextDouble() * MathHelper.TwoPi),
                    (float)Math.Sin(Main.random.NextDouble() * MathHelper.TwoPi));
                randomOffset *= Radius / 4f;

                if (Radius > 24)
                    ParticleManager.particles.Add(
                        new AsteroidDebris(
                            impact.X + randomOffset.X,
                            impact.Y + randomOffset.Y,
                            Velocity.X + ((impact.X + randomOffset.X) - Position.X),
                            Velocity.Y + ((impact.Y + randomOffset.Y) - Position.Y),
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 1f, 1f + (float)Main.random.NextDouble(),
                            teamIndex, Main.random.Next(2, 9), 1.1f, 4, 5,
                            Color.MediumTurquoise, Color.MediumTurquoise, Color.SteelBlue));

                ParticleManager.particles.Add(
                    new Blur(
                        impact.X + randomOffset.X,
                        impact.Y + randomOffset.Y,
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
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.DrawWithLighting(spriteBatch, Color.MediumTurquoise, 6f);
        }
    }
}