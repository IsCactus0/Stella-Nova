using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Enemies.Types
{
    public class Wraith : Enemy
    {
        public Wraith()
        {
        }
        public Wraith(float x, float y) 
            : base(x, y)
        {
            Variation = Main.random.Next(0, 128);
            Arms = new List<KinematicArm>();
            for (int i = 0; i < 6; i++)
                Arms.Add(
                    new KinematicArm(32 + (int)(4f * Variation / 128f), 4 + (2f * Variation / 128f), 3, 12, false,
                        // Color.Lerp(Color.Tomato, Color.Coral, Variation / 128f),
                        // Color.Lerp(Color.SaddleBrown, Color.IndianRed, Variation / 128f)));
                        Color.Lerp(Color.DarkSlateBlue, Color.DarkCyan, Variation / 128f),
                        Color.Lerp(Color.MidnightBlue, Color.DarkMagenta, Variation / 128f)));
            SightRange = 200f;
            MoveSpeed = 4f;
            MinMoveSpeed = MoveSpeed;
            MaxMoveSpeed = 10f;
            Health = 500f;
            MaxHealth = 500f;
            Friction = 0.9f;
            Mass = 32;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wraith(float x, float y, float vx, float vy) 
            : base(x, y, vx, vy)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed)
        {

        }
        public Wraith(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed, float turnSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed, turnSpeed)
        {

        }

        public List<KinematicArm> Arms;
        public float SightRange;
        public float PullStrength;
        public float Variation;

        public float MaxMoveSpeed;
        public float MinMoveSpeed;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(50f, 6);
        }
        public override void Destroy()
        {
            for (int i = 0; i < 64; i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 32f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * 32f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        randomOffset.X * 5f,
                        randomOffset.Y * 5f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f,
                        2f + (float)Main.random.NextDouble(), TeamIndex, Main.random.Next(32, 64),
                        Color.Indigo * 0.2f, Color.Black, Color.Navy * 0.1f, 0.2f));
            }

            base.Destroy();
        }
        public override void FindCollisions()
        {

        }
        public override void Damage(int damage, int minDamage, int maxDamage, float critBonus, bool isCrit, int teamIndex, Vector2 impact)
        {
            for (int i = 0; i < 32; i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 24f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * 24f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        randomOffset.X * 5f,
                        randomOffset.Y * 5f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f,
                        2f + (float)Main.random.NextDouble(), TeamIndex, Main.random.Next(64, 128),
                        Color.MediumOrchid * 0.2f, Color.Black, Color.Navy * 0.1f, 0.2f));
            }

            Vector2 direction = Position - impact;
            direction.Normalize();
            Acceleration += direction * 10000f;

            MoveSpeed = MaxMoveSpeed;

            if (damage > MaxHealth / 10f)
            {
                if (Arms.Count > 0)
                {
                    Tentacle tentacle = new Tentacle();
                    tentacle.Position = Position;
                    tentacle.Segments = Arms[0];
                    ParticleManager.particles.Add(tentacle);
                    Arms.RemoveAt(0);
                }
            }

            base.Damage(damage, minDamage, maxDamage, critBonus, isCrit, teamIndex, impact);
        }
        public override void Update(float delta)
        {
            if (MoveSpeed > MinMoveSpeed)
            {
                // Should result in move speed returning to normal after half a second has elapsed...
                MoveSpeed -= delta * MaxMoveSpeed * 2f;
                if (MoveSpeed < MinMoveSpeed)
                    MoveSpeed = MinMoveSpeed;
            }

            for (int i = 0; i < Arms.Count; i++)
            {
                SpaceObject grabbed = null;
                if (TimeAlive > 1f)
                {
                    // Grab the player if in range...
                    if (Vector2.Distance(Position, PlayerManager.player.Position) <= SightRange)
                        grabbed = PlayerManager.player;
                    // Otherwise find the nearest asteroid to the tip of the arm...
                    else grabbed = (Asteroid)AsteroidManager.FindNearest(Arms[i].Joints[0].Position, SightRange);
                }
                
                // If no object was found start roaming...
                if (grabbed is null)
                {
                    float noise = (float)Main.openSimplexNoise.Evaluate(0, 0, Main.NoiseOffset * MoveSpeed / 10f + (Variation + i) * 100f);

                    Arms[i].Follow(Position + new Vector2((float)Math.Cos(noise * MathHelper.TwoPi), (float)Math.Sin(noise * MathHelper.TwoPi)) * SightRange, delta);
                    Arms[i].Limit(Position);
                    continue;
                }
                
                Vector2 toObject = grabbed.Position - Arms[i].Joints[0].Position;
                float distance = toObject.Length();
                
                if (grabbed is Asteroid)
                    toObject *= (distance - ((Asteroid)grabbed).Radius) / distance;

                Arms[i].Follow(Arms[i].Joints[0].Position + (toObject *  distance), delta * MoveSpeed / 2f);
                Arms[i].Limit(Position);

                // If the arm reaches the asteroid...
                if (distance <= 0.03f || (grabbed is Asteroid && distance <= ((Asteroid)grabbed).Radius + 0.01f))
                { 
                    if (grabbed is Player)
                        ((Player)grabbed).Damage(Main.random.Next(32) + 1, 1, 32, 0.1f, Main.random.NextDouble() < 0.5f, TeamIndex, grabbed.Position);
                    else
                    {
                        Vector2 target;
                        if (Vector2.Distance(Position, PlayerManager.player.Position) <= SightRange * 4f)
                            target = PlayerManager.player.Position;
                        else target = Position + new Vector2(Main.random.Next(-100, 100), Main.random.Next(-100, 100));

                        Vector2 toPlayer = grabbed.Position - target;
                        toPlayer.Normalize();

                        float force = 20000f;
                        Acceleration -= toPlayer * force / 5f / Mass;
                        grabbed.Acceleration += toPlayer * force / grabbed.Mass;
                    }
                }
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (KinematicArm arm in Arms)
                for (int i = 1; i < arm.Joints.Count; i++)
                {
                    // float thickness = Utility.Map(i, 0, arm.Joints.Count - 1, arm.StartThickness, arm.EndThickness);
                    float thickness = (float)Math.Sin((i - 1f) / arm.Joints.Count * MathHelper.Pi) * arm.EndThickness + arm.StartThickness;
                    Color colour = Color.Lerp(arm.BaseColour, arm.TipColour, (float)i / arm.Joints.Count);
                    Drawing.DrawLine(spriteBatch, arm.Joints[i - 1].Position, arm.Joints[i].Position, colour * 0.5f, thickness * 1.4f);
                    Drawing.DrawLine(spriteBatch, arm.Joints[i - 1].Position, arm.Joints[i].Position, colour, thickness * 0.5f);
                }
        }
    }
}