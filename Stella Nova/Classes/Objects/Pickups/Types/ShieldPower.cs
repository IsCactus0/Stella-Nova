using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Effects;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class ShieldPower : Pickup
    {
        public ShieldPower()
        {
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public ShieldPower(float x, float y) : base(x, y)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public ShieldPower(float x, float y, float vx, float vy) : base(x, y, vx, vy)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public ShieldPower(float x, float y, float vx, float vy, float ax, float ay) : base(x, y, vx, vy, ax, ay)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public ShieldPower(float x, float y, float vx, float vy, float ax, float ay, float angle) : base(x, y, vx, vy, ax, ay, angle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public ShieldPower(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public ShieldPower(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public ShieldPower(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public ShieldPower(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(24, 6);
        }
        public override void OnPickup(Player player)
        {
            if (player.Statuses.Any(x => x is Shield))
            {
                Shield shield = (Shield)player.Statuses.Find(x => x is Shield);
                shield.Time = 0;
                shield.Strength = shield.MaxStrength;
                shield.Radius = shield.MaxRadius;
            }
            else player.Statuses.Add(new Shield());

            base.OnPickup(player);
        }
        public override void Update(float delta)
        {
            Polygon.Rotate(delta * Velocity.Y / 100f, Axis.X);
            Polygon.Rotate(delta * -Velocity.X / 100f, Axis.Y);

            if (Utility.CalculateChancePerSecond(delta, 0.01f))
                ParticleManager.particles.Add(
                    new Blur(
                        Position.X,
                        Position.Y,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 1f, 0.4f + (float)Main.random.NextDouble() / 20f, 0, 20,
                        Color.SandyBrown,
                        Color.SaddleBrown));

            if (Utility.CalculateChancePerSecond(delta, 0.05f))
                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + Main.random.Next(-6, 6),
                        Position.Y + Main.random.Next(-6, 6),
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 1f, 0.1f, 0, 20,
                        Color.FromNonPremultiplied(232, 156, 1, 256),
                        Color.LightYellow,
                        Color.Gold));

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.DrawWithLighting(spriteBatch, Color.White, 3f);
        }
    }
}