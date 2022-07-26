using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Abilities;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Projectiles;
using Stella_Nova.Classes.Objects.Weapons;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects
{
    public class Player : Spacecraft
    {
        public Player()
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Player(float x, float y)
            : base(x, y)
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];
            PickupRange = 25f;

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            MoveSpeed = 800f;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MoveSpeed = 800f;
            TurnSpeed = 4f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 0;
            MaxShieldStrength = 45;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new LaserRifle(),
                new SolarPhaser(),
                new PlasmaRifle(),
                new ShockCannon(),
            };
            Abilities = new List<Ability>()
            {
                new Shield()
            };
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Player(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float moveSpeed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MoveSpeed = moveSpeed;
            TurnSpeed = 8f;
            TeamIndex = 0;
            Score = 0;
            SelectedWeapon = 0;
            ShieldStrength = 1000;
            MaxShieldStrength = ShieldStrength;
            ShieldRadius = 100f;
            PickupRange = 25f;
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];


            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
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
            Colour = PlayerManager.colours[Main.random.Next(PlayerManager.colours.Count)];

            Weapons = new List<Weapon>()
            {
                new SolarPhaser(),
                new PlasmaRifle()
            };
            Abilities = new List<Ability>();
            Pickups = new List<Pickup>();

            Mass = 100f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public Color Colour;
        public double Score;
        public int SelectedWeapon;
        public float ShieldStrength;
        public float MaxShieldStrength;
        public float ShieldRadius;
        public float PickupRange;

        protected float turnStrength = 0f;

        public List<Pickup> Pickups;

        public bool IsWarping = false;
        public float WarpCharge = 0f;
        public float MaxWarpCharge = 10f;

        public Dictionary<string, Keys> KeyboardMap = new Dictionary<string, Keys>()
        {
            { "thrust", Keys.W },
            { "turn_left", Keys.A },
            { "turn_right", Keys.D },
            { "weapon_fire", Keys.Space },
            { "weapon_reload", Keys.R },
            { "weapon_wheel_left", Keys.Q },
            { "weapon_wheel_right", Keys.E },
            { "warp_jump", Keys.T },
            { "activate_selected_ability", Keys.O },
            { "deactivate_selected_ability", Keys.P },
        };
        public Dictionary<string, Buttons> GamePadMap = new Dictionary<string, Buttons>()
        {
            { "thrust", Buttons.RightTrigger },
            // { "turn_left", Buttons.Left },
            // { "turn_right", Keys.D },
            { "weapon_fire", Buttons.A },
            { "weapon_reload", Buttons.X },
            { "weapon_wheel_left", Buttons.LeftShoulder },
            { "weapon_wheel_right", Buttons.RightShoulder },
            { "warp_jump", Buttons.DPadUp },
        };

        protected GamePadState PrevGamePadState;
        protected GamePadState CurrGamePadState;
        protected KeyboardState PrevKeyboardState;
        protected KeyboardState CurrKeyboardState;

        public override List<Vector2> GenerateShape()
        {
            return base.GenerateShape();
        }
        public override void FindCollisions()
        {
            if (IsWarping)
                return;

            if (ShieldStrength > 0)
            {
                foreach (Asteroid asteroid in AsteroidManager.FindAll(this.Position, ShieldRadius))
                {
                    if (ShieldStrength > 0)
                        break;

                    AsteroidManager.Destroy(asteroid);
                    ShieldStrength -= asteroid.Radius / 32;
                }
            }

            foreach (Asteroid asteroid in AsteroidManager.FindAll(this))
            {
                if (Health <= 0)
                {
                    Reset();
                    break;
                }

                AsteroidManager.Destroy(asteroid);
                Health -= asteroid.Radius / 10;
                Velocity *= 1f - asteroid.Radius / 64;
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
                this.Destroy();
                return;
            }

            // Update User Inputs...
            PrevGamePadState = CurrGamePadState;
            CurrGamePadState = GamePad.GetState(TeamIndex);
            PrevKeyboardState = CurrKeyboardState;
            CurrKeyboardState = Keyboard.GetState();

            // Turning...
            if (CurrKeyboardState.IsKeyDown(KeyboardMap["turn_left"]))
                turnStrength = -1;
            else if (CurrKeyboardState.IsKeyDown(KeyboardMap["turn_right"]))
                turnStrength = 1;
            else if (CurrGamePadState.ThumbSticks.Left.X != 0)
                turnStrength = CurrGamePadState.ThumbSticks.Left.X;
            else turnStrength = 0f;

            if (turnStrength != 0f)
            {
                Angle += delta * turnStrength * TurnSpeed;
                if (turnStrength < 0f && Polygon.Roll > -0.9f)
                    Polygon.Roll += delta * turnStrength * TurnSpeed;
                else if (turnStrength > 0f && Polygon.Roll < 0.9f)
                    Polygon.Roll += delta * turnStrength * TurnSpeed;
            }
            else
            {
                if (Polygon.Roll > 0.01f)
                {
                    Polygon.Roll -= delta * TurnSpeed;
                    if (Polygon.Roll < 0f)
                        Polygon.Roll = 0f;
                }
                else if (Polygon.Roll < 0.01f)
                {
                    Polygon.Roll += delta * TurnSpeed;
                    if (Polygon.Roll > 0f)
                        Polygon.Roll = 0f;
                }
                else 
                Polygon.Roll = 0f;
            }

            // Thrust...
            if (CurrKeyboardState.IsKeyDown(KeyboardMap["thrust"]))
                thrustStrength = 1f;
            else if (CurrGamePadState.Triggers.Right != 0)
                thrustStrength = CurrGamePadState.Triggers.Right;
            else thrustStrength = 0f;

            // Abilities...
            foreach (Ability ability in Abilities)
                if (ability.isActive)
                    ability.Update(delta, this);

            // Firing...
            Weapons[SelectedWeapon].Update(delta,
                CurrGamePadState.IsButtonDown(GamePadMap["weapon_fire"]) || CurrKeyboardState.IsKeyDown(KeyboardMap["weapon_fire"]),
                CurrGamePadState.IsButtonDown(GamePadMap["weapon_reload"]) || CurrKeyboardState.IsKeyDown(KeyboardMap["weapon_reload"]),
                this, TeamIndex);

            // Rotating Weapons...
            if ((CurrGamePadState.IsButtonDown(GamePadMap["weapon_wheel_right"]) && PrevGamePadState.IsButtonUp(GamePadMap["weapon_wheel_right"])) ||
                (CurrKeyboardState.IsKeyDown(KeyboardMap["weapon_wheel_right"]) && PrevKeyboardState.IsKeyUp(KeyboardMap["weapon_wheel_right"])))
            {
                SelectedWeapon++;
                if (SelectedWeapon >= Weapons.Count)
                    SelectedWeapon = 0;
            }
            else if ((CurrGamePadState.IsButtonDown(GamePadMap["weapon_wheel_left"]) && PrevGamePadState.IsButtonUp(GamePadMap["weapon_wheel_left"])) ||
                    (CurrKeyboardState.IsKeyDown(KeyboardMap["weapon_wheel_left"]) && PrevKeyboardState.IsKeyUp(KeyboardMap["weapon_wheel_left"])))
            {
                SelectedWeapon--;
                if (SelectedWeapon < 0)
                    SelectedWeapon = Weapons.Count - 1;
            }
            // Warping...
            if (!IsWarping && (
                (CurrGamePadState.IsButtonDown(GamePadMap["warp_jump"]) && PrevGamePadState.IsButtonUp(GamePadMap["warp_jump"])) ||
                (CurrKeyboardState.IsKeyDown(KeyboardMap["warp_jump"]) && PrevKeyboardState.IsKeyUp(KeyboardMap["warp_jump"]))))
            {
                IsWarping = true;
            }
            if (IsWarping)
            {
                Vector2 direction = new Vector2(
                    (float)Math.Cos(Angle),
                    (float)Math.Sin(Angle));

                if (Velocity.Length() < 2000)
                    Acceleration += direction * 2000f;
                else Jump();
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!IsWarping || WarpCharge < MaxWarpCharge / 3f)
               Polygon.DrawWithLighting(spriteBatch, Color.PowderBlue, 2f);

            foreach (Ability ability in Abilities)
                if (ability.isActive)
                    ability.Draw(spriteBatch, this);
        }
        public void Jump()
        {
            ProjectileManager.projectiles.Add(
                new Shockwave(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 20, 1000, 3000f, 20f));

            Vector2 direction = new Vector2(
                (float)Math.Cos(Angle),
                (float)Math.Sin(Angle));

            // for (int i = 0; i < 1000; i++)
            // {
            //     Position += direction;
            // 
            //     ParticleManager.particles.Add(
            //         new Warp(
            //             Position.X,
            //             Position.Y,
            //             (float)Math.Cos((Main.random.NextDouble() - 0.5f) * MathHelper.Pi) * (1000 - i) / 4f,
            //             (float)Math.Sin((Main.random.NextDouble() - 0.5f) * MathHelper.Pi) * (1000 - i) / 4f,
            //             0f, 0f,
            //             (float)Main.random.NextDouble() - 0.5f,
            //             (float)Main.random.NextDouble() - 0.5f,
            //             0f,
            //             0.1f,
            //             0.7f,
            //             (0.2f + (float)Main.random.NextDouble() * 0.5f) - ((1000f - i) / 1000f) * 0.2f,
            //             Main.random.Next(24, 32),
            //             Color.Black, Color.DeepSkyBlue, Color.Indigo, 100f, this));
            // }

            Velocity = direction * 1000f;
            IsWarping = false;
            WarpCharge = 0f;
        }
        public void Pickup(Pickup pickup)
        {
            Pickups.Add(pickup);
            pickup.Destroy();
        }
        public void Reset()
        {
            this.Health = this.MaxHealth;
            this.ShieldStrength = this.MaxShieldStrength;

            this.Position = new Vector2(Main.graphics.PreferredBackBufferWidth / 2, Main.graphics.PreferredBackBufferHeight / 2);
            this.Velocity = Vector2.Zero;
            this.Acceleration = Vector2.Zero;

            foreach (Ability ability in Abilities)
                ability.Reset();

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