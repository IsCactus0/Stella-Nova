using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Objects.Projectiles;
using Stella_Nova.Classes.Objects.Projectiles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Weapons.Types
{
    public class SolarPhaser : Weapon
    {
        public SolarPhaser()
            : base()
        {
            Barrels = new List<Vector2>() { new Vector2(-12, 12), new Vector2(-12, -12) };
            MagazineSize = 64;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels)
            : base(barrels)
        {
            MagazineSize = 64;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize)
            : base(barrels, magazineSize)
        {
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize, int loaded)
            : base(barrels, magazineSize, loaded)
        {
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize, int loaded, int ammunition)
            : base(barrels, magazineSize, loaded, ammunition)
        {
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount)
        {
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex)
        {
            FireRate = 0.1f;
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate)
        {
            Spread = 0f;
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread)
        {
            Velocity = 1000f;

            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }
        public SolarPhaser(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            ShootSounds = new List<SoundEffect>() {
                SoundManager.LaserShoot0,
                SoundManager.LaserShoot1,
                SoundManager.LaserShoot2,
            };
            ReloadSounds = new List<SoundEffect>() {
                SoundManager.LaserReload0,
                SoundManager.LaserReload1,
                SoundManager.LaserReload2,
            };
            EmptySounds = new List<SoundEffect>() {
                SoundManager.LaserEmpty0,
                SoundManager.LaserEmpty1,
                SoundManager.LaserEmpty2,
            };
        }

        public override void CreateMuzzleFlash(Vector2 pos, Vector2 vel, float angle, int teamIndex)
        {
            ParticleManager.particles.Add(
                new Blur(
                    pos.X, pos.Y,
                    vel.X + (float)Math.Cos(angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * 50f,
                    vel.Y + (float)Math.Sin(angle + (Main.random.NextDouble() - 0.5f) * 0.2f) * 50f,
                    0f, 0f,
                    (float)Main.random.NextDouble() - 0.5f,
                    (float)Main.random.NextDouble() - 0.5f,
                    0f, 10f, 0.7f, (float)Main.random.NextDouble() + 0.2f, teamIndex,
                    Main.random.Next(24, 32),
                    Color.DimGray, Color.Black));

            ParticleManager.particles.Add(
                new Spark(
                    pos.X, pos.Y,
                    vel.X,
                    vel.Y,
                    0f, 0f,
                    (float)Main.random.NextDouble() - 0.5f,
                    (float)Main.random.NextDouble() - 0.5f,
                    0f, 10f, 1f, 0.1f, teamIndex,
                    Main.random.Next(32, 40),
                    Color.DarkOrange, Color.LightGoldenrodYellow, Color.Maroon));

            for (int i = 0; i < 10; i++)
            {
                Vector2 randomMuzzleFlash = Utility.RotateVector(new Vector2(Main.random.Next(250, 500), 0), angle + (float)(Main.random.NextDouble() - 0.5f) * 2f);

                ParticleManager.particles.Add(
                    new Spark(
                        pos.X, pos.Y,
                        vel.X + randomMuzzleFlash.X,
                        vel.Y + randomMuzzleFlash.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 1f, 0.1f,
                        teamIndex,
                        Main.random.Next(8, 16),
                        Color.Orange, Color.LightGoldenrodYellow, Color.Maroon));
            }
        }
        public override void CreateNewProjectile(Vector2 pos, Vector2 vel, float angle, int playerIndex)
        {
            Projectile temp = new CopperWarhead(pos.X, pos.Y, vel.X, vel.Y, 0f, 0f, angle, 0f, 0f, 1f, 0.8f, playerIndex, 1, 5, 14, 0.23f, 1.4f, 2f);
            ProjectileManager.projectiles.Add(temp);
        }
        public override void CreateShells(Vector2 pos, Vector2 vel, float angle, int playerIndex)
        {
        }
    }
}