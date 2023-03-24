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
    public class Artillery : Weapon
    {
        public Artillery()
        {
            Barrels = new List<Vector2>() { new Vector2(16, 0) };
            MagazineSize = 1;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 1f;
            Spread = 0f;
            Velocity = 8000f;

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
        public Artillery(List<Vector2> barrels) 
            : base(barrels)
        {
            Barrels = barrels;
            MagazineSize = 128;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.2f;
            Spread = 0f;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize) 
            : base(barrels, magazineSize)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.2f;
            Spread = 0f;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize, int loaded) 
            : base(barrels, magazineSize, loaded)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.2f;
            Spread = 0f;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize, int loaded, int ammunition) 
            : base(barrels, magazineSize, loaded, ammunition)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.2f;
            Spread = 0f;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount) 
            : base(barrels, magazineSize, loaded, ammunition, projectileCount)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = 0;
            FireRate = 0.2f;
            Spread = 0f;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = 0.2f;
            Spread = 0f;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate) 
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = fireRate;
            Spread = 0f;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread) 
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = fireRate;
            Spread = spread;
            Velocity = 4000f;

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
        public Artillery(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate, spread, velocity)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = fireRate;
            Spread = spread;
            Velocity = velocity;

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
            for (int i = 0; i < 32; i++)
            {
                Vector2 randomMuzzleFlash = Utility.RotateVector(new Vector2(Main.random.Next(250, 500), 0), angle + (float)(Main.random.NextDouble() - 0.5f) * 2f);

                ParticleManager.particles.Add(
                    new Smoke(
                        pos.X, pos.Y,
                        vel.X + randomMuzzleFlash.X * ((float)Main.random.NextDouble() / 2f + 0.5f),
                        vel.Y + randomMuzzleFlash.Y * ((float)Main.random.NextDouble() / 2f + 0.5f),
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f, (float)Main.random.NextDouble() + 2f, teamIndex, Main.random.Next(128, 256),
                        Color.Tan * 0.1f, Color.Sienna * 0.2f, 0.2f));

            }

            for (int i = 0; i < 128; i++)
            {
                Vector2 randomMuzzleFlash = Utility.RotateVector(new Vector2(Main.random.Next(250, 500), 0), angle + (float)(Main.random.NextDouble() - 0.5f) * 2f);
                
                ParticleManager.particles.Add(
                    new Smoke(
                        pos.X, pos.Y,
                        vel.X + randomMuzzleFlash.X * ((float)Main.random.NextDouble() / 2f + 0.5f),
                        vel.Y + randomMuzzleFlash.Y * ((float)Main.random.NextDouble() / 2f + 0.5f),
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f, (float)Main.random.NextDouble() / 2f + 0.5f, teamIndex, Main.random.Next(24, 64),
                        Color.DarkOrange * 0.25f, Color.Maroon * 0.1f, 0.2f));
            }

            for (int i = 0; i < 32; i++)
            {
                Vector2 randomMuzzleFlash = Utility.RotateVector(new Vector2(Main.random.Next(250, 500), 0), angle + (float)(Main.random.NextDouble() - 0.5f) * 2f);

                ParticleManager.particles.Add(
                    new Spark(
                        pos.X, pos.Y,
                        vel.X + randomMuzzleFlash.X * 1.5f,
                        vel.Y + randomMuzzleFlash.Y * 1.5f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 1f, (float)Main.random.NextDouble() / 4f + 0.1f, teamIndex,
                        Main.random.Next(16, 24),
                        Color.Orange, Color.White, Color.Maroon));
            }
        }
        public override void CreateNewProjectile(Vector2 pos, Vector2 vel, float angle, int teamIndex)
        {
            Projectile temp = new Bullet(pos.X, pos.Y, vel.X, vel.Y, 0f, 0f, angle, 0f, 0f, 1f, 1f, teamIndex, 10, 500, 1400, 0.23f, 1.4f, 10f, 48, 8, 0.005f, Color.DarkOrange * 0.2f, Color.Maroon * 0.5f);
            ProjectileManager.projectiles.Add(temp);

            base.CreateNewProjectile(pos, vel, angle, teamIndex);
        }
        public override void CreateShells(Vector2 pos, Vector2 vel, float angle, int teamIndex)
        {
            Vector2 rotatedBarrel = Utility.RotateVector(Barrels[BarrelIndex], angle);
            float shellAngle = (MathHelper.Pi / 2f) * (1 + (BarrelIndex * -2));

            Shell shell = new Shell(
                    pos.X + rotatedBarrel.X / 2f,
                    pos.Y + rotatedBarrel.Y / 2f,
                    vel.X + (float)Math.Cos(angle + shellAngle + (Main.random.NextDouble() - 0.5f) * 0.2f) * 150f,
                    vel.Y + (float)Math.Sin(angle + shellAngle + (Main.random.NextDouble() - 0.5f) * 0.2f) * 150f,
                    0f, 0f,
                    angle, ((float)Main.random.NextDouble() - 0.5f) * 2f, 0f,
                    0.1f, 0.8f, 10f, teamIndex);

            shell.Polygon.Scale(2f);

            ParticleManager.particles.Add(shell);
        }
    }
}