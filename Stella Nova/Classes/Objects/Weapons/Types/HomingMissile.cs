using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Objects.Projectiles;
using Stella_Nova.Classes.Objects.Projectiles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Weapons.Types
{
    public class HomingMissile : Weapon
    {
        public HomingMissile()
            : base()
        {
            Barrels = new List<Vector2>() { new Vector2(-12, 14), new Vector2(-12, -14) };
            MagazineSize = 12;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 0.1f;
            Spread = 0.1f;
            Velocity = 500f;
        }
        public HomingMissile(List<Vector2> barrels)
            : base(barrels)
        {
            Barrels = barrels;
            MagazineSize = 4;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 1f;
            Spread = 0.1f;
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize)
            : base(barrels, magazineSize)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = MagazineSize;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 1f;
            Spread = 0.1f;
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize, int loaded)
            : base(barrels, magazineSize, loaded)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = 1024;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 1f;
            Spread = 0.1f;
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize, int loaded, int ammunition)
            : base(barrels, magazineSize, loaded, ammunition)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = 1;
            BarrelIndex = 0;
            FireRate = 1f;
            Spread = 0.1f;
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = 0;
            FireRate = 1f;
            Spread = 0.1f;
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = 1f;
            Spread = 0.1f;
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate)
            : base(barrels, magazineSize, loaded, ammunition, projectileCount, barrelIndex, fireRate)
        {
            Barrels = barrels;
            MagazineSize = magazineSize;
            Loaded = loaded;
            Ammunition = ammunition;
            ProjectileCount = projectileCount;
            BarrelIndex = barrelIndex;
            FireRate = fireRate;
            Spread = 0.1f;
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread)
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
            Velocity = 2000f;
        }
        public HomingMissile(List<Vector2> barrels, int magazineSize, int loaded, int ammunition, int projectileCount, int barrelIndex, float fireRate, float spread, float velocity)
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
        }

        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>()
            {
                new Vector2(18f, -4f),
                new Vector2(30f, -4f),
                new Vector2(30f,  4f),
                new Vector2(18f,  4f)
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
                    0f, 10f, 0.7f, (float)Main.random.NextDouble() + 0.2f, teamIndex, Main.random.Next(24, 32),
                    Color.DimGray, Color.Black));
            ParticleManager.particles.Add(
                new Spark(
                    pos.X, pos.Y,
                    vel.X, vel.Y,
                    0f, 0f,
                    (float)Main.random.NextDouble() - 0.5f,
                    (float)Main.random.NextDouble() - 0.5f,
                    0f, 10f, 1f, 0.1f, teamIndex, Main.random.Next(32, 40),
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
                        0f, 10f, 1f, 0.1f, teamIndex,
                        Main.random.Next(8, 16),
                        Color.Orange, Color.LightGoldenrodYellow, Color.Maroon));
            }
        }
        public override void CreateShells(Vector2 pos, Vector2 vel, float angle, int teamIndex)
        {

        }
        public override void CreateNewProjectile(Vector2 pos, Vector2 vel, float angle, int teamIndex)
        {
            Projectile temp = new Missile(pos.X, pos.Y, vel.X, vel.Y, 0f, 0f, angle, 0f, 0f, 1f, 0.8f, teamIndex, 1, 5, 14, 0.23f, 1.9f, 3f);
            // Projectile temp = new Grenade(pos.X, pos.Y, vel.X, vel.Y, 0f, 0f, angle, 0f, 0f, 1f, 0.8f, teamIndex, 1, 5, 14, 0.23f, 1.9f, 3f);
            ProjectileManager.projectiles.Add(temp);

            base.CreateNewProjectile(pos, vel, angle, teamIndex);
        }
        public override void Draw(SpriteBatch spriteBatch, Vector2 pos, float angle)
        {
            base.Draw(spriteBatch, pos, angle);
        }
    }
}