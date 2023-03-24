using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Weapons
{
    public abstract class ChargingWeapon : EnergyWeapon
    {
        public ChargingWeapon()
        {
            MainBarrel = new Vector2(80, 0);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels)
            : base(barrels)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize)
            : base(barrels, magazineSize)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded)
            : base(barrels, magazineSize, loaded)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition)
            : base(barrels, magazineSize, loaded, ammunition)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            MainBarrel = new Vector2(0, 32);
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity, Vector2 mainBarrel)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            MainBarrel = mainBarrel;
            ChargeTime = 3f;
        }
        public ChargingWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity, Vector2 mainBarrel, float chargeTime)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            MainBarrel = mainBarrel;
            ChargeTime = chargeTime;
        }

        public Vector2 MainBarrel;
        public float ChargeTime;
        public float Charge;

        public List<SoundEffect> LoopSounds;

        public override void Update(float delta, bool trigger, bool reload, SpaceObject source, int teamIndex)
        {
            Vector2 tempPos = source.Position +
                Utility.RotateVector(MainBarrel, source.Angle) +
                Utility.RotateVector(new Vector2(15, 0), source.Angle);

            Vector2 tempVel = source.Velocity +
                new Vector2(
                (float)Math.Cos(source.Angle + (Main.random.NextDouble() - 0.5f) * MathHelper.Pi * Spread),
                (float)Math.Sin(source.Angle + (Main.random.NextDouble() - 0.5f) * MathHelper.Pi * Spread)) * Velocity;

            if (trigger)
            {
                if (Charge >= ChargeTime)
                {
                    LastFired += delta;
                    if (LastFired >= FireRate)
                    {
                        LastFired = 0;

                        for (int i = 0; i < ProjectileCount; i++)
                            CreateNewProjectile(tempPos, tempVel, source.Angle, teamIndex);
                        CreateMuzzleFlash(tempPos, source.Velocity, source.Angle, teamIndex);
                        CreateShells(tempPos, source.Velocity, source.Angle, teamIndex);
                    }
                }
                else Charge += delta;

                lastBarrel = BarrelIndex;
                BarrelIndex++;
                if (BarrelIndex >= Barrels.Count)
                    BarrelIndex = 0;

                if (Utility.CalculateChancePerSecond(delta, 3f))
                {
                    Vector2 mainPos = source.Position + Utility.RotateVector(MainBarrel, source.Angle);
                    foreach (Vector2 barrel in Barrels)
                    {
                        tempPos = source.Position + Utility.RotateVector(barrel, source.Angle);
                        CreateChargeEffects(tempPos, mainPos, source.Velocity);
                    }
                }
            }
            else if (reload)
                Reload(tempPos, tempVel, source.Angle, teamIndex);
            else if (Charge > 0)
            {
                Charge -= delta * 2f;
                if (Charge < 0f)
                    Charge = 0f;
            }
        }
        public abstract void CreateChargeEffects(Vector2 pos, Vector2 main, Vector2 sourceVel);
        public override void Draw(SpriteBatch spriteBatch, Vector2 pos, float angle)
        {
            base.Draw(spriteBatch, pos, angle);
        }
        public override void DrawUI(SpriteBatch spriteBatch)
        {
            // Draw Ammunition
            Vector2 loadedStringSize = UIManager.Roboto_Medium.MeasureString($"{Loaded}") * 0.4f * Main.camera.Scale;
            Vector2 totalStringSize = UIManager.Roboto_Light.MeasureString($"/{Ammunition}") * 0.2f * Main.camera.Scale;
            Vector2 chargeStringSize = UIManager.Roboto_Light.MeasureString("/" + (Charge / ChargeTime).ToString("0.00")) * 0.2f * Main.camera.Scale;

            // Loaded
            spriteBatch.DrawString(
                UIManager.Roboto_Medium, $"{Loaded}",
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth * Main.camera.Scale - loadedStringSize.X - 200 * Main.camera.Scale,
                    Main.graphics.PreferredBackBufferHeight * Main.camera.Scale - loadedStringSize.Y - 64 * Main.camera.Scale),
                Color.PowderBlue, 0f, Vector2.Zero, 0.4f * Main.camera.Scale, SpriteEffects.None, 0);
            // Ammunition
            spriteBatch.DrawString(
                UIManager.Roboto_Light, $"/{Ammunition}",
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth - totalStringSize.X - (200 - totalStringSize.X),
                    Main.graphics.PreferredBackBufferHeight - totalStringSize.Y - 72),
                Color.PowderBlue, 0f, Vector2.Zero, 0.2f * Main.camera.Scale, SpriteEffects.None, 0);
            // Charge
            spriteBatch.DrawString(
                UIManager.Roboto_Light, " " + (Charge / ChargeTime).ToString("0.00"),
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth - chargeStringSize.X - (200 - totalStringSize.X),
                    Main.graphics.PreferredBackBufferHeight - chargeStringSize.Y - (72 - totalStringSize.Y)),
                Color.PowderBlue, 0f, Vector2.Zero, 0.2f, SpriteEffects.None, 0);

            Drawing.DrawLine(spriteBatch,
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth - chargeStringSize.X - (200 - totalStringSize.X),
                    Main.graphics.PreferredBackBufferHeight - chargeStringSize.Y - (72 - totalStringSize.Y - 16)),
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth - chargeStringSize.X - (200 - totalStringSize.X) - (Charge / ChargeTime) * 100f,
                    Main.graphics.PreferredBackBufferHeight - chargeStringSize.Y - (72 - totalStringSize.Y - 16)),
                Color.PowderBlue * 0.75f, 16f);
        }
    }
}