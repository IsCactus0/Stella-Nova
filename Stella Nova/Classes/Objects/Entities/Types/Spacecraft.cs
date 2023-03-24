using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Effects;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Objects.Weapons;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Entities.Types
{
    public class Spacecraft : Entity
    {
        public Spacecraft()
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Spacecraft(float x, float y)
            : base(x, y)
        {
            MoveSpeed = 1000f; 
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            MoveSpeed = 1000f;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed)
        {
            MoveSpeed = moveSpeed;
            TurnSpeed = 4f;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Spacecraft(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed, float turnSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            MoveSpeed = moveSpeed;
            TurnSpeed = turnSpeed;
            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public float MoveSpeed;
        public float TurnSpeed;
        public float ThrustStrength;

        public List<Weapon> Weapons;
        public List<Status> Statuses;

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
            for (int i = Statuses.Count - 1; i >= 0; i--)
            {
                if (Statuses[i].isActive)
                    Statuses[i].Update(delta, this);
                else Statuses.RemoveAt(i);
            }

            if (ThrustStrength > 0)
            {
                Acceleration += new Vector2(
                (float)Math.Cos(Angle) * MoveSpeed,
                (float)Math.Sin(Angle) * MoveSpeed);

                if (Utility.CalculateChancePerSecond(delta, ThrustStrength * 5f))
                {
                    ParticleManager.particles.Add(
                        new Spark(
                            Position.X - (float)Math.Cos(Angle) * 16f,
                            Position.Y - (float)Math.Sin(Angle) * 16f,
                            (float)Math.Cos(Angle + (Main.random.NextDouble() - 0.5f) * 0.3f) * -150f * 2f,
                            (float)Math.Sin(Angle + (Main.random.NextDouble() - 0.5f) * 0.3f) * -150f * 2f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.05f,
                            0.3f + (float)Main.random.NextDouble() / 5f, TeamIndex, Main.random.Next(12, 32),
                            Color.OrangeRed, Color.LightGoldenrodYellow, Color.Maroon));

                    ParticleManager.particles.Add(
                        new Smoke(
                            Position.X - (float)Math.Cos(Angle) * 16f,
                            Position.Y - (float)Math.Sin(Angle) * 16f,
                            (float)Math.Cos(Angle + (Main.random.NextDouble() - 0.5f) * 0.3f) * -150f * 2f,
                            (float)Math.Sin(Angle + (Main.random.NextDouble() - 0.5f) * 0.3f) * -150f * 2f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.05f,
                            1.5f + (float)Main.random.NextDouble() / 10f, TeamIndex, Main.random.Next(48, 64),
                            Color.Gray * 0.2f, Color.Black, 0.5f));
                }
            }

            base.Update(delta);
        }
    }
}