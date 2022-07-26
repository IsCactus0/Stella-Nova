using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Weapons
{
    public abstract class Weapon
    {
        public Weapon()
        {
            Barrels = new List<Vector2>() { Vector2.Zero };
            MagazineSize = 32;
            Loaded = MagazineSize;
            Ammunition = 128;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = 32;
            Loaded = MagazineSize;
            Ammunition = 128;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 2;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = magazineSize;
            Ammunition = 128;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 2;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize, int loaded)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = 128;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 2;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 2;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = 0;
            FireRate = 2;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = 2;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = fireRate;
            Spread = 0;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = fireRate;
            Spread = spread;
            Velocity = 400f;
        }
        public Weapon(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity)
        {
            Barrels = new List<Vector2>(barrels);
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = fireRate;
            Spread = spread;
            Velocity = velocity;

            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }

        public Polygon Polygon;
        public List<Vector2> Barrels;

        public int MagazineSize;
        public int Loaded;
        public int Ammunition;
        public int ProjectileCount;
        public int BarrelIndex;

        public float FireRate;
        public float Spread;
        public float Velocity;
        public float LastFired;

        protected int lastBarrel;

        public virtual List<Vector2> GenerateShape()
        {
            return new List<Vector2>()
            {
                new Vector2(  0f, -5f) * 0.8f,
                new Vector2( 20f, -5f) * 0.8f,
                new Vector2( 15f,  5f) * 0.8f,
                new Vector2( -5f,  5f) * 0.8f
            };
        }
        public virtual void Update(float delta, bool trigger, bool reload, SpaceObject source, int teamIndex)
        {
            LastFired += delta;
            if (LastFired >= FireRate)
            {
                // Firing.
                if (trigger)
                {
                    LastFired = 0;

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
                else if (reload)
                {
                    Reload();
                }
            }
        }
        public abstract void CreateMuzzleFlash(Vector2 pos, Vector2 vel, float angle, int teamIndex);
        public abstract void CreateNewProjectile(Vector2 pos, Vector2 vel, float angle, int teamIndex);
        public virtual void CreateShells(Vector2 pos, Vector2 vel, float angle, int teamIndex)
        {
            Vector2 rotatedBarrel = Utility.RotateVector(Barrels[BarrelIndex], angle);
            float shellAngle = (MathHelper.Pi / 2f) * (1 + (BarrelIndex * -2));

            ParticleManager.particles.Add(
                new Shell(
                    pos.X + rotatedBarrel.X / 2f,
                    pos.Y + rotatedBarrel.Y / 2f,
                    vel.X + (float)Math.Cos(angle + shellAngle + (Main.random.NextDouble() - 0.5f) * 0.2f) * 150f,
                    vel.Y + (float)Math.Sin(angle + shellAngle + (Main.random.NextDouble() - 0.5f) * 0.2f) * 150f,
                    0f, 0f,
                    angle, ((float)Main.random.NextDouble() - 0.5f) * 2f, 0f,
                    0.1f, 0.8f, 10f, teamIndex));
        }
        public virtual void Reload()
        {
            LastFired = 0;
            Ammunition -= MagazineSize - Loaded;
            Loaded = MagazineSize;
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            // Draw Ammunition
            Vector2 loadedStringSize = Main.Roboto_Medium.MeasureString($"{PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].Loaded}") * 0.4f;
            Vector2 totalStringSize = Main.Roboto_Light.MeasureString($"/{PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].Ammunition}") * 0.2f;
            spriteBatch.DrawString(
                Main.Roboto_Medium, $"{PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].Loaded}",
                new Vector2(Main.graphics.PreferredBackBufferWidth - 256 - loadedStringSize.X * 0.4f, Main.graphics.PreferredBackBufferHeight - 64 - loadedStringSize.Y / 2f),
                Color.PowderBlue, 0f, Vector2.Zero, 0.4f, SpriteEffects.None, 0);
            spriteBatch.DrawString(
                Main.Roboto_Light, $"/{PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].Ammunition}",
                new Vector2(Main.graphics.PreferredBackBufferWidth - 256 + loadedStringSize.X * 0.65f, Main.graphics.PreferredBackBufferHeight - 64 - totalStringSize.Y / 2f),
                Color.PowderBlue, 0f, Vector2.Zero, 0.2f, SpriteEffects.None, 0);
            
        }
    }
}