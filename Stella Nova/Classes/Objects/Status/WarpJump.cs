using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Objects.Projectiles.Types;
using Stella_Nova.Classes.Utilities;
using System;

namespace Stella_Nova.Classes.Objects.Effects
{
    public class WarpJump : Status
    {
        public WarpJump()
        {
            MaxTime = 50f;
            IsWarping = false;
            ChargeTime = 3f;
            TravelDistance = 1000f;
        }
        public WarpJump(float useTime)
            : base(useTime)
        {
            MaxTime = 50f;
            IsWarping = false;
            ChargeTime = 3f;
            TravelDistance = 1000f;
        }

        public bool IsWarping;
        public float ChargeTime;
        public float TravelDistance;

        public override void Update(float delta, Entity origin)
        {
            LastUsed += delta;

            if (!IsWarping && LastUsed >= UseTime &&
                ((Main.currGamePadState.IsButtonDown(PlayerManager.GamePadMap["warp_jump"]) &&
                Main.prevGamePadState.IsButtonUp(PlayerManager.GamePadMap["warp_jump"])) ||
                (Main.currKeyboardState.IsKeyDown(PlayerManager.KeyboardMap["warp_jump"]) &&
                Main.prevKeyboardState.IsKeyUp(PlayerManager.KeyboardMap["warp_jump"]))))
            {
                IsWarping = true;
                LastUsed = 0f;
            }

            if (IsWarping)
            {
                Vector2 direction = new Vector2((float)Math.Cos(origin.Angle), (float)Math.Sin(origin.Angle));
                origin.Acceleration += direction * 2500f;

                if (Utility.CalculateChancePerSecond(delta, 0.5f))
                {
                    float tempAngle = (float)Main.random.NextDouble() * MathHelper.TwoPi;

                    ParticleManager.particles.Add(new Warp(
                        origin.Position.X + (float)Math.Cos(tempAngle),
                        origin.Position.Y + (float)Math.Sin(tempAngle),
                        (float)Math.Cos(tempAngle + MathHelper.PiOver2) * 200f,
                        (float)Math.Sin(tempAngle + MathHelper.PiOver2) * 200f,
                        0f, 0f,
                        ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                        ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                        0f,
                        0, 0.1f, 3f, origin.TeamIndex, Main.random.Next(2, 12),
                        Color.Red,
                        Color.Crimson,
                        Color.Maroon * 0.25f,
                        2f, origin));
                }

                if (LastUsed >= ChargeTime)
                {
                    ProjectileManager.projectiles.Add(
                        new Shockwave(
                            origin.Position.X, origin.Position.Y,
                            0f, 0f, 0f, 0f,
                            0f, 0f, 0f,
                            0f, 0f, origin.TeamIndex,
                            9999, 256, 300, 0.3f, 1.9f,
                            20, 1000, 3000f, 20f));

                    origin.Position += direction * TravelDistance;
                    IsWarping = false;
                }
            }

            base.Update(delta, origin);
        }
        public override void Draw(SpriteBatch spritebatch, Entity origin)
        {
            
        }
        public override void DrawUI(SpriteBatch spritebatch)
        {
            throw new NotImplementedException();
        }
    }
}