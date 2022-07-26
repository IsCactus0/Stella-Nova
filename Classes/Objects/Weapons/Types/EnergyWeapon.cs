using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Weapons
{
    public abstract class EnergyWeapon : Weapon
    {
        protected EnergyWeapon()
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels)
            : base(barrels)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize)
            : base(barrels, magazineSize)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded)
            : base(barrels, magazineSize, loaded)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition)
            : base(barrels, magazineSize, loaded, ammunition)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            StartingCharge = 3f;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity, float startingStrength)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            StartingCharge = startingStrength;
            ChargeStrength = StartingCharge;
        }
        protected EnergyWeapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity, float startingStrength, float chargeStrength)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            StartingCharge = startingStrength;
            ChargeStrength = chargeStrength;
        }

        public float StartingCharge;
        public float ChargeStrength;

        public override void Update(float delta, bool trigger, bool reload, SpaceObject source, int teamIndex)
        {
            LastFired += delta;
            if (LastFired >= FireRate)
            {
                // Firing.
                if (trigger)
                {
                    LastFired = 0;
                    ChargeStrength = StartingCharge;

                    if (Loaded <= 0)
                        return;
                    Loaded--;

                    Vector2 tempPos = source.Position +
                        Utility.RotateVector(Barrels[BarrelIndex], source.Angle) +
                        Utility.RotateVector(new Vector2(15, 0), source.Angle);

                    for (int i = 0; i < ProjectileCount; i++)
                    {
                        Vector2 tempVel = source.Velocity +
                            new Vector2(
                            (float)Math.Cos(source.Angle + (Main.random.NextDouble() - 0.5f) * MathHelper.Pi * Spread),
                            (float)Math.Sin(source.Angle + (Main.random.NextDouble() - 0.5f) * MathHelper.Pi * Spread)) * Velocity;

                        CreateNewProjectile(tempPos, tempVel, source.Angle, teamIndex);
                    }

                    CreateMuzzleFlash(tempPos, source.Velocity, source.Angle, teamIndex);
                    CreateShells(tempPos, source.Velocity, source.Angle, teamIndex);

                    lastBarrel = BarrelIndex;
                    BarrelIndex++;
                    if (BarrelIndex >= Barrels.Count)
                        BarrelIndex = 0;
                }
                else if (LastFired >= 1 / ChargeStrength)
                {
                    Reload();
                    LastFired = 0f;
                }
            }
        }
        public override void Reload()
        {
            if (Loaded < MagazineSize)
            {
                ChargeStrength *= 1.1f;
                if (ChargeStrength > 30)
                    ChargeStrength = 30;                

                Loaded += 1;
                if (Loaded > MagazineSize)
                    Loaded = MagazineSize;
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            // Draw Ammunition
            Vector2 loadedStringSize = Main.Roboto_Medium.MeasureString($"{PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].Loaded}") * 0.4f;
            Vector2 totalStringSize = Main.Roboto_Light.MeasureString($"\u221E") * 0.2f;
            spriteBatch.DrawString(
                Main.Roboto_Medium, $"{PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].Loaded}",
                new Vector2(Main.graphics.PreferredBackBufferWidth - 256 - loadedStringSize.X * 0.4f, Main.graphics.PreferredBackBufferHeight - 64 - loadedStringSize.Y / 2f),
                Color.PowderBlue, 0f, Vector2.Zero, 0.4f, SpriteEffects.None, 0);
            spriteBatch.DrawString(
                Main.Roboto_Light, $"/\u221E",
                new Vector2(Main.graphics.PreferredBackBufferWidth - 256 + loadedStringSize.X * 0.65f, Main.graphics.PreferredBackBufferHeight - 64 - totalStringSize.Y / 2f),
                Color.PowderBlue, 0f, Vector2.Zero, 0.2f, SpriteEffects.None, 0);
        }
    }
}