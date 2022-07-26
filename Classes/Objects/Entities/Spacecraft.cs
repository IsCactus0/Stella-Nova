using Microsoft.Xna.Framework;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Abilities;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Objects.Weapons;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Entities
{
    public class Spacecraft : Entity
    {
        public Spacecraft()
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y)
            : base(x, y)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed)
        {
            MoveSpeed = moveSpeed;
            TurnSpeed = 4f;
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed, float turnSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            MoveSpeed = moveSpeed;
            TurnSpeed = turnSpeed;
        }

        public float MoveSpeed;
        public float TurnSpeed;

        public List<Weapon> Weapons;
        public List<Ability> Abilities;

        protected float thrustStrength = 0f;

        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>()
            {
                new Vector2(   7.0f, -0.5f) * 4.5f,
                new Vector2(   2.0f, -1.5f) * 4.5f,
                new Vector2(   0.0f, -1.5f) * 4.5f,
                new Vector2(  -3.0f, -0.5f) * 4.5f,
                new Vector2(  -2.5f, -2.0f) * 4.5f,
                new Vector2(   1.0f, -2.5f) * 4.5f,
                new Vector2(  -1.0f, -4.0f) * 4.5f,
                new Vector2(  -2.5f, -3.5f) * 4.5f,
                new Vector2(  -5.0f, -2.5f) * 4.5f,

                new Vector2(  -4.0f, -2.0f) * 4.5f,
                new Vector2(  -5.0f, -1.0f) * 4.5f,
                new Vector2(  -5.0f,  1.0f) * 4.5f,
                new Vector2(  -4.0f,  2.0f) * 4.5f,

                new Vector2(  -5.0f,  2.5f) * 4.5f,
                new Vector2(  -2.5f,  3.5f) * 4.5f,
                new Vector2(  -1.0f,  4.0f) * 4.5f,
                new Vector2(   1.0f,  2.5f) * 4.5f,
                new Vector2(  -2.5f,  2.0f) * 4.5f,
                new Vector2(  -3.0f,  0.5f) * 4.5f,
                new Vector2(   0.0f,  1.5f) * 4.5f,
                new Vector2(   2.0f,  1.5f) * 4.5f,
                new Vector2(   7.0f,  0.5f) * 4.5f
            };
        }
        public override void Update(float delta)
        {
            if (thrustStrength != 0f)
            {
                Acceleration += new Vector2(
                    (float)Math.Cos(Angle) * thrustStrength * MoveSpeed,
                    (float)Math.Sin(Angle) * thrustStrength * MoveSpeed);

                if (Utilities.Utility.CalculateChancePerSecond(delta, thrustStrength * 10f))
                {
                    ParticleManager.particles.Add(
                        new Blur(
                            Position.X - (float)Math.Cos(Angle) * 16f,
                            Position.Y - (float)Math.Sin(Angle) * 16f,
                            (float)Math.Cos(Angle + (Main.random.NextDouble() - 0.5f) * 2f) * -40f * thrustStrength,
                            (float)Math.Sin(Angle + (Main.random.NextDouble() - 0.5f) * 2f) * -40f * thrustStrength,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 0.7f, (float)Main.random.NextDouble() * 0.2f, TeamIndex, Main.random.Next(24, 32), Color.DimGray, Color.Black));

                    ParticleManager.particles.Add(
                        new Spark(
                            Position.X - (float)Math.Cos(Angle) * 16f,
                            Position.Y - (float)Math.Sin(Angle) * 16f,
                            (float)Math.Cos(Angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * -200f * thrustStrength,
                            (float)Math.Sin(Angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * -200f * thrustStrength,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 0.05f, (float)Main.random.NextDouble() * 0.3f, TeamIndex, Main.random.Next(8, 16), Color.Cyan, Color.White, Color.RoyalBlue));
                }
            }

            base.Update(delta);
        }
    }
}