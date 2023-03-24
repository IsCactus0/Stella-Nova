using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Effects;
using Stella_Nova.Classes.Objects.Entities.Types;
using Stella_Nova.Classes.Objects.Weapons;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects
{
    public class Player : Spacecraft
    {
        public Player()
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;

            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Player(float x, float y)
            : base(x, y)
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;

            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;


            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;


            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            
            PickupRange = 25f;

            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;


            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;


            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            MoveSpeed = 400f;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;


            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MoveSpeed = 400f;
            TurnSpeed = 60f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 0;
            MaxShieldStrength = 45;
            ShieldRadius = 100f;
            Health = 500;
            MaxHealth = 500;

            Weapons = new List<Weapon>();
            Statuses = new List<Status>();

            PickupRange = 50f;
            MaxCarryable = 5;
            Pickups = new List<Pickup>();

            AudioListener = new AudioListener();
            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float moveSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MoveSpeed = moveSpeed;
            TurnSpeed = 20f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;

            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float moveSpeed, float turnSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MoveSpeed = moveSpeed;
            TurnSpeed = turnSpeed;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;


            Weapons = new List<Weapon>();
            Statuses = new List<Status>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public double Score;
        public int SelectedWeapon;
        public float ShieldStrength;
        public float MaxShieldStrength;
        public float ShieldRadius;

        public float PickupRange;
        public int MaxCarryable;
        public List<Pickup> Pickups;

        public AudioListener AudioListener;

        public override List<Vector2> GenerateShape()
        {
            return base.GenerateShape();
        }
        public override void FindCollisions()
        {
            foreach (Pickup pickup in PickupManager.FindAll(this.Position, PickupRange))
            {
                if (Pickups.Count >= MaxCarryable)
                    break;
                if (pickup.Parent != this)
                    pickup.OnPickup(this);
            }

            float overlap, distance;
            Vector2 direction, normal, tangental;
            foreach (Asteroid asteroid in AsteroidManager.FindAll(this))
            {
                if (Health <= 0)
                {
                    Reset();
                    break;
                }

                // Find direction and distance.
                direction = Position - asteroid.Position;
                distance = direction.Length();
                normal = direction / distance;

                // Calculate overlap.
                overlap = 0.5f * (distance - asteroid.Radius - 32f);

                // Displace by overlap.
                // Position -= overlap * normal;
                asteroid.Position += overlap * normal;

                // Tangental.
                tangental.X = -1f * normal.Y;
                tangental.Y = normal.X;

                // Dot product tangental.
                float dpTan1 = Velocity.X * tangental.X + Velocity.Y * tangental.Y;
                float dpTan2 = asteroid.Velocity.X * tangental.X + asteroid.Velocity.Y * tangental.Y;

                // Dot product normal.
                float dpNorm1 = Velocity.X * normal.X + Velocity.Y * normal.Y;
                float dpNorm2 = asteroid.Velocity.X * normal.X + asteroid.Velocity.Y * normal.Y;

                // Conservation of momentum in 1D.
                float m1 = (dpNorm1 * (Mass - asteroid.Mass) + 2.0f * asteroid.Mass * dpNorm2) / (Mass + asteroid.Mass);
                float m2 = (dpNorm2 * (asteroid.Mass - Mass) + 2.0f * Mass * dpNorm1) / (Mass + asteroid.Mass);

                Velocity = tangental * dpTan1 + normal * m1;
                asteroid.Velocity = tangental * dpTan2 + normal * m2;

                float force1 = Velocity.Length() * Mass;
                float force2 = asteroid.Velocity.Length() * asteroid.Mass;

                int damage;
                if (force1 > 10000f)
                {
                    damage = (int)(Math.Clamp(force1 - 10000f, 0f, 1000f) / 100f);
                    if (damage > 0)
                        asteroid.Damage(damage, 0, 1000, 0, false, TeamIndex, Position + normal * 32f);
                }
                if (force2 > 10000f)
                {
                    damage = (int)(Math.Clamp(force2 - 10000f, 0f, 1000f) / 100f);
                    if (damage > 0)
                        Damage(damage, 0, 1000, 0, false, asteroid.TeamIndex, Position + normal * asteroid.Radius * -1f);
                }
            }
        }
        public override void Destroy()
        {
            Reset();
            Score -= 100;
            if (Score < 0)
                Score = 0;
        }
        public override void Update(float delta)
        {
            if (Health <= 0)
            {
                Destroy();
                return;
            }

            AudioListener.Position = new Vector3(
                Position.X * SoundManager.SoundScale,
                Position.Y * SoundManager.SoundScale, 0);
            AudioListener.Velocity = new Vector3(
                Velocity.X * SoundManager.SoundScale,
                Velocity.Y * SoundManager.SoundScale, 0);

            // Turning...
            if (Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["turn_left"]))
                AngularAcceloration += -1 * TurnSpeed;
            else if (Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["turn_right"]))
                AngularAcceloration += 1 * TurnSpeed;
            else if (Main.currGamePadState.ThumbSticks.Left.X != 0)
                AngularAcceloration += Main.currGamePadState.ThumbSticks.Left.X * TurnSpeed;

            // Thrust...
            if (Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["thrust"]))
                ThrustStrength = 1f;
            else if (Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["reverse"]))
                ThrustStrength = -0.5f;
            else if (Main.currGamePadState.Triggers.Right != 0)
                ThrustStrength = Main.currGamePadState.Triggers.Right;
            else ThrustStrength = 0f;

            // Firing...
            if (Weapons.Count > 0)
                Weapons[SelectedWeapon].Update(delta,
                    Main.currGamePadState.IsButtonDown(PlayerManager.GamePadMap["weapon_fire"]) || 
                    Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["weapon_fire"]),
                    Main.currGamePadState.IsButtonDown(PlayerManager.GamePadMap["weapon_reload"]) ||
                    Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["weapon_reload"]),
                    this, TeamIndex);

            // Rotating Weapons...
            if ((Main.currGamePadState.IsButtonDown(PlayerManager.GamePadMap["weapon_wheel_right"]) &&
                Main.prevGamePadState.IsButtonUp(PlayerManager.GamePadMap["weapon_wheel_right"])) ||
                (Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["weapon_wheel_right"]) &&
                Main.prevKeyboardState.IsKeyUp(PlayerManager.KeyboardMap["weapon_wheel_right"])))
            {
                SelectedWeapon++;
                if (SelectedWeapon >= Weapons.Count)
                    SelectedWeapon = 0;
            }
            else if ((Main.currGamePadState.IsButtonDown(PlayerManager.GamePadMap["weapon_wheel_left"]) &&
                    Main.prevGamePadState.IsButtonUp(PlayerManager.GamePadMap["weapon_wheel_left"])) ||
                    (Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["weapon_wheel_left"]) &&
                    Main.prevKeyboardState.IsKeyUp(PlayerManager.KeyboardMap["weapon_wheel_left"])))
            {
                SelectedWeapon--;
                if (SelectedWeapon < 0)
                    SelectedWeapon = Weapons.Count - 1;
            }
            
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (Status ability in Statuses)
                if (ability.isActive)
                    ability.Draw(spriteBatch, this);

            if (Weapons.Count > 0)
                Weapons[SelectedWeapon].Draw(spriteBatch, Position, Angle);

            Polygon.DrawWithLighting(spriteBatch, Color.FromNonPremultiplied(232, 156, 1, 256), 2f);
        }
        public void Reset()
        {
            this.Score = 0;

            this.Health = this.MaxHealth;
            this.ShieldStrength = this.MaxShieldStrength;

            this.Position = new Vector2(Main.graphics.PreferredBackBufferWidth / 2, Main.graphics.PreferredBackBufferHeight / 2);
            this.Velocity = Vector2.Zero;
            this.Acceleration = Vector2.Zero;

            this.Polygon.Roll = 0;
            this.Polygon.Yaw = 0;
            this.Polygon.Pitch = 0;
            this.Polygon.Origin = new Vector3(Position.X, Position.Y, 0f);

            this.Angle = 0;
            this.AngularVelocity = 0;
            this.AngularAcceloration = 0;
            this.TimeAlive = 0f;
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}