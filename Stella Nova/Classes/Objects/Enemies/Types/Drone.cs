using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Effects;
using Stella_Nova.Classes.Objects.Pickups.Types;
using Stella_Nova.Classes.Objects.Projectiles.Types;
using Stella_Nova.Classes.Objects.Weapons;
using Stella_Nova.Classes.Objects.Weapons.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Enemies.Types
{
    public class Drone : Enemy
    {
        public Drone()
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new HomingMissile();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Friction = 0.4f;
            Mass = 100f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Drone(float x, float y)
            : base(x, y)
        {
            TargetAngle = 0f;
            SightRange = 3000f;
            AttackRange = 1000f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new LaserRifle() { Barrels = new List<Vector2>() { new Vector2(12, 0) }};
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Friction = 0.4f;
            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            Friction = 0.4f;
            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Friction = 0.4f;
            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Friction = 0.4f;
            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Friction = 0.4f;
            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Friction = 0.4f;
            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Friction = 0.4f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            TeamIndex = 3;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = 600f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Drone(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float moveSpeed, float turnSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, moveSpeed, turnSpeed)
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            LastSeen = Target;
            Weapon = new SolarPhaser();
            Statuses = new List<Status>();
            State = AIState.Searching;
            MoveSpeed = moveSpeed;
            TurnSpeed = turnSpeed;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        protected float TargetAngle;
        protected float SightRange;
        protected float AttackRange;
        protected float TimeSinceLastSeen;
        protected float SpeedMultiplier;
        protected Vector2 Target;
        protected Vector2 LastSeen;
        protected Color stateColour = Color.White;

        public override List<Vector2> GenerateShape()
        {
            return base.GenerateShape();
        }
        public override void FindCollisions()
        {
            base.FindCollisions();
        }
        public override void Destroy()
        {
            PickupManager.pickups.Add(new ShieldPower(Position.X, Position.Y));
            ProjectileManager.projectiles.Add(new Explosion(Position.X, Position.Y));
            base.Destroy();
        }
        public override void Update(float delta)
        {
            TimeSinceLastSeen += delta;
            SpeedMultiplier = 1f;

            float distance = Vector2.Distance(Position, Target);
            Vector2 towardsTarget = Target - Position;
            Vector3 towardsTarget3d = new Vector3(towardsTarget, 0f);
            Vector3 currentlyFacing = new Vector3((float)Math.Cos(Angle), (float)Math.Sin(Angle), 0);
            float crossProductSign = Vector3.Cross(currentlyFacing, towardsTarget3d).Z;

            if (!(PlayerManager.player is null))
                Target = PlayerManager.player.Position;

            switch (State)
            {
                case AIState.Idling:
                    stateColour = Color.Green;
                    SpeedMultiplier = 0f;
                    if (distance < SightRange)
                    {
                        if (Health < MaxHealth / 4f)
                            State = AIState.Fleeing;
                        else State = AIState.Chasing;
                    }
                    break;
                case AIState.Searching:
                    stateColour = Color.LightGoldenrodYellow;
                    SpeedMultiplier = 1f;

                    if (Weapon.Loaded < Weapon.MagazineSize)
                        Weapon.Update(delta, false, Utility.CalculateChancePerSecond(delta, 0.01f), this, TeamIndex);

                    if (TimeSinceLastSeen > 5f)
                    {
                        State = AIState.Idling;
                        break;
                    }
                    if (Vector2.Distance(Position, Target) <= SightRange)
                    {
                        State = AIState.Chasing;
                        break;
                    }
                    if (distance < 50f)
                    {
                        float randomAngle = (float)(Main.random.NextDouble() - 0.5f) * MathHelper.TwoPi;
                        LastSeen += new Vector2((float)Math.Cos(randomAngle), (float)Math.Sin(randomAngle)) * SightRange;
                    }
                    break;
                case AIState.Chasing:
                    stateColour = Color.DarkOrange;
                    TimeSinceLastSeen = 0f;
                    SpeedMultiplier = 2.5f;

                    if (Health < MaxHealth / 4f)
                    {
                        State = AIState.Fleeing;
                        break;
                    }

                    if (distance > SightRange)
                        State = AIState.Searching;
                    else if (distance <= AttackRange)
                        State = AIState.Attacking;
                    break;
                case AIState.Attacking:
                    stateColour = Color.Red;
                    TimeSinceLastSeen = 0f;
                    SpeedMultiplier = 0f;

                    if (Health < MaxHealth / 4f)
                    {
                        State = AIState.Fleeing;
                        break;
                    }

                    if (distance <= AttackRange)
                        Weapon.Update(delta, Weapon.Loaded != 0, Weapon.Loaded == 0 && Utility.CalculateChancePerSecond(delta, 0.01f), this, TeamIndex);
                    else
                    {
                        State = AIState.Chasing;
                        break;
                    }

                    break;

                case AIState.Fleeing:
                    stateColour = Color.BlueViolet;
                    TimeSinceLastSeen = 0f;
                    SpeedMultiplier = 2.5f;

                    if (distance <= SightRange)
                        crossProductSign *= -1f;
                    else State = AIState.Idling;
                    break;

                default:
                    stateColour = Color.White;
                    break;
            }

            if (crossProductSign < 0)
                Angle -= TurnSpeed * delta;
            else if (crossProductSign > 0)
                Angle += TurnSpeed * delta;

            ThrustStrength = ((distance + 100f) / 600000f) * (MoveSpeed * SpeedMultiplier);

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.DrawWithLighting(spriteBatch, Color.White);

            foreach (Status ability in Statuses)
                if (ability.isActive)
                    ability.Draw(spriteBatch, this);
        }
    }
}