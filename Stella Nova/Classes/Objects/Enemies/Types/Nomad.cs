using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Enemies.Types
{
    public class Nomad : Enemy
    {
        public Nomad()
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Nomad(float x, float y)
            : base(x, y)
        {
            Friction = 0.5f;
            Tentacles = new List<KinematicArm>();
            for (int i = -5; i < 6; i++)
                if (i == 0)
                    Tentacles.Add(new KinematicArm(12, 16, 32, 1, true, Color.FromNonPremultiplied(232, 156, 1, 256), Color.MediumPurple));
                else Tentacles.Add(new KinematicArm(24 - Math.Abs(i), 16, 10, 1, true, Color.White, Color.White));

            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Nomad(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }
        public Nomad(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed, float turnSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed, turnSpeed)
        {
            Arm = new KinematicArm(4, 12, 10, 1, true);
            Tentacles = new List<KinematicArm>()
            {
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
                new KinematicArm(7, 16, 10, 1, true),
            };
        }

        public KinematicArm Arm;
        public List<KinematicArm> Tentacles;

        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>()
            {
                new Vector2(-1f,  1f) * 24,
                new Vector2( 2f,  0f) * 24,
                new Vector2(-1f, -1f) * 24,
            };
        }
        public override void FindCollisions()
        {
            base.FindCollisions();
        }
        public override void Destroy()
        {
            base.Destroy();
        }
        public override void Update(float delta)
        {
            float angle = (float)Main.openSimplexNoise.Evaluate(
                Position.X / 10000f, Position.Y / 10000f,
                Main.NoiseOffset / 10000f) * MathHelper.TwoPi;

            Angle = angle;

            if (TimeAlive % 3f < 0.2f)
            {
                Acceleration += new Vector2(
                    (float)Math.Cos(angle),
                    (float)Math.Sin(angle)) * 2000f;
            }

            for (int i = 0; i < Tentacles.Count; i++)
            {
                Vector2 offset = Utilities.Utility.RotateVector(new Vector2(0, i - Tentacles.Count / 2f), Angle) * 25f;
                Tentacles[i].Follow(Position + offset, delta);
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            // Arm.Draw(spriteBatch);
            for (int i = 0; i < Tentacles.Count; i++)
                Tentacles[i].Draw(spriteBatch);

            base.Draw(spriteBatch);
        }
        public override SpaceObject Clone()
        {
            return base.Clone();
        }
    }
}