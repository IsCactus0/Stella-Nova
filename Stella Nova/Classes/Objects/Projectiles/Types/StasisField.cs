using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class StasisField : Projectile
    {
        public StasisField()
            : base()
        {
            Radius = 128;
            MaxLifespan = 500f;
            Mass = float.PositiveInfinity;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public StasisField(float x, float y)
            : base(x, y)
        {
            Radius = 128;
            MaxLifespan = 5f;
            Mass = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public float Radius;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(Radius, Radius / 4f);
        }
        public override void FindCollisions()
        {
            List<SpaceObject> spaceObjects = AsteroidManager.FindAll(Position, Radius)
                        .Concat<SpaceObject>(ParticleManager.FindAll(Position, Radius))
                        .Concat(EntityManager.FindAll(Position, Radius))
                        .Concat(ProjectileManager.FindAll(Position, Radius)).ToList();

            if (Vector2.Distance(PlayerManager.player.Position, Position) <= Radius)
                spaceObjects.Add(PlayerManager.player);

            spaceObjects.Remove(this);

            if (spaceObjects.Count == 0)
                return;

            for (int i = 0; i < spaceObjects.Count; i++)
                Velocity = Vector2.Zero;
        }
        public override void Destroy()
        {
            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 0.5f))
            {
                float tempAngle = (float)Main.random.NextDouble() * MathHelper.TwoPi;
            
                ParticleManager.particles.Add(new Warp(
                    Position.X + (float)Math.Cos(tempAngle) * Radius,
                    Position.Y + (float)Math.Sin(tempAngle) * Radius,
                    (float)Math.Cos(tempAngle + MathHelper.PiOver2) * 250f,
                    (float)Math.Sin(tempAngle + MathHelper.PiOver2) * 250f,
                    0f, 0f,
                    ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                    ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                    0f,
                    0, 0.1f, 3f, TeamIndex - 1, Main.random.Next(2, 12),
                    Color.Red,
                    Color.Crimson,
                    Color.Maroon * 0.25f,
                    -1f, this));
            }

            if (Utility.CalculateChancePerSecond(delta, 0.01f))
            {
                float angle = (float)Main.random.NextDouble() * MathHelper.TwoPi;
                Vector2 direction = new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));
                direction *= (float)Main.random.NextDouble() * Radius;

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + direction.X,
                        Position.Y + direction.Y,
                        0f, 0f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.05f,
                        2f + (float)Main.random.NextDouble(), TeamIndex - 1, Main.random.Next(32, 128),
                        Color.Black, Color.Black, Color.Crimson * 0.2f, 20f));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Color.RoyalBlue * 0.2f, 3f);
        }

    }
}
