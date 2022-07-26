using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Abilities;
using Stella_Nova.Classes.Objects.Projectiles;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Enemies
{
    public class Drone : Enemy
    {
        public Drone()
        {
            TargetAngle = 0f;
            SightRange = 900f;
            AttackRange = 500f;
            TimeSinceLastSeen = 0f;
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
            Abilities = new List<Abilities.Ability>();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.LaserRifle() { Barrels = new List<Vector2>() { new Vector2(12, 0) } };
            Abilities = new List<Ability>();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            Target = PlayerManager.player.Position;
            LastSeen = Target;
            Weapon = new Weapons.SolarPhaser();
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
            return Drawing.Ellipse(24, 8);
        }
        public override void FindCollisions()
        {
            base.FindCollisions();
        }
        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(new Explosion(this.Position.X, this.Position.Y));
            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (Health <= 0)
                this.Destroy();

            foreach (Ability ability in Abilities)
                if (ability.isActive)
                    ability.Update(delta, this);

            TimeSinceLastSeen += delta;
            SpeedMultiplier = 1f;

            float distance = Vector2.Distance(Position, Target);
            Vector2 towardsTarget = Target - Position;
            Vector3 towardsTarget3d = new Vector3(towardsTarget, 0f);
            Vector3 currentlyFacing = new Vector3((float)Math.Cos(Angle), (float)Math.Sin(Angle), 0);
            float crossProductSign = Vector3.Cross(currentlyFacing, towardsTarget3d).Z;

            switch (State)
            {
                case AIState.Idling:
                    stateColour = Color.Green;
                    Target = PlayerManager.player.Position;
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
                    Target = PlayerManager.player.Position;
                    SpeedMultiplier = 1f;

                    if (Weapon.Loaded < Weapon.MagazineSize)
                        Weapon.Update(delta, false, Utility.CalculateChancePerSecond(delta, 0.01f), this, TeamIndex);

                    if (TimeSinceLastSeen > 5f)
                    {
                        State = AIState.Idling;
                        break;
                    }
                    if (Vector2.Distance(Position, PlayerManager.player.Position) <= SightRange)
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
                    Target = PlayerManager.player.Position;
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
                    Target = PlayerManager.player.Position;
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
                    Target = PlayerManager.player.Position;
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

            thrustStrength = ((distance + 100f) / 600000f) * (MoveSpeed * SpeedMultiplier);

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.DrawWithLighting(spriteBatch, Color.White);

            foreach (Ability ability in Abilities)
                if (ability.isActive)
                    ability.Draw(spriteBatch, this);
        }
    }
}