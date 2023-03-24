using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Entities.Types
{
    public class Wormhole : Entity
    {
        public Wormhole()
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Wormhole(float x, float y)
            : base(x, y)
        {
            Radius = 100;
            Detail = 128;
            Quality = 150;
            Speed = 103f;
            Size = Radius * 3f;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = 200;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;            
            Detail = detail;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int detail, int quality)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;            
            Detail = detail;
            Quality = quality;
            Speed = 50f;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int detail, int quality, float speed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;            
            Detail = detail;
            Quality = quality;
            Speed = speed;
            Size = Radius;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int detail, int quality, float speed, float size)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            Detail = detail;
            Quality = quality;
            Speed = speed;
            Size = size;
            ShineColour = Color.CornflowerBlue * 2f;
            FlareColour = Color.RoyalBlue;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int detail, int quality, float speed, float size, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            Detail = detail;
            Quality = quality;
            Speed = speed;
            Size = size;
            ShineColour = colour * 2f;
            FlareColour = colour;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Wormhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int detail, int quality, float speed, float size, Color shineColour, Color flareColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            Detail = detail;
            Quality = quality;
            Speed = speed;
            Size = size;
            ShineColour = flareColour;
            FlareColour = shineColour;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public int Radius;
        public int Detail;
        public int Quality;
        public float Speed;
        public float Size;
        public Color ShineColour;
        public Color FlareColour;
        public Vector2 Exit;

        private float offsetX = Main.random.Next(1000);
        private float offsetY = Main.random.Next(1000);

        public override List<Vector2> GenerateShape()
        {
            List<Vector2> vertices = new List<Vector2>();
            for (float angle = 0; angle < MathHelper.TwoPi; angle += MathHelper.TwoPi / Detail)
            {
                Vector2 vertice = new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));
                vertice *= Radius + (float)Main.openSimplexNoise.Evaluate(vertice.X + offsetX * Speed, vertice.Y + offsetY * Speed) * Size;
                vertices.Add(vertice);
            }

            return vertices;
        }
        public override void FindCollisions()
        {
            List<SpaceObject> spaceObjects = AsteroidManager.FindAll(Position, Radius).Cast<SpaceObject>()
                .Concat(EntityManager.FindAll(Position, Radius))
                .Concat(ParticleManager.FindAll(Position, Radius))
                .Concat(PickupManager.FindAll(Position, Radius))
                .Concat(ProjectileManager.FindAll(Position, Radius)).ToList();

            if (Vector2.Distance(PlayerManager.player.Position, Position) <= Radius)
                spaceObjects.Add(PlayerManager.player);

            foreach (SpaceObject spaceObject in spaceObjects)
            {
                if (spaceObject is Wormhole || spaceObject.TimeAlive < 0.3f)
                    continue;

                spaceObject.TimeAlive = 0;
                spaceObject.Position += Exit - Position;
            }
        }
        public override void Update(float delta)
        {
            offsetX += delta * 0.01f;
            offsetY += delta * 0.01f;

            Polygon.OriginalVertices = new List<Vector3>();
            foreach (Vector2 vertice in GenerateShape())
                Polygon.OriginalVertices.Add(new Vector3(vertice.X, vertice.Y, 0));

            if (Utility.CalculateChancePerSecond(delta, 0.08f))
            {
                float angle = (float)((Main.random.NextDouble() - 0.5f) * MathHelper.TwoPi);

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + (float)Math.Cos(angle) * 80f,
                        Position.Y + (float)Math.Sin(angle) * 80f,
                        (float)Math.Cos(angle) * 20f * ((float)Math.Cos(TimeAlive) + 10f) * Main.random.Next(2),
                        (float)Math.Sin(angle) * 20f * ((float)Math.Cos(TimeAlive) + 10f) * Main.random.Next(2),
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0f,
                        1f,
                        2f + ((float)Main.random.NextDouble() / 20f),
                        TeamIndex,
                        23,
                        Color.Blue,
                        Color.White,
                        Color.HotPink));

                ParticleManager.particles.Add(
                    new Blur(
                        Position.X + (float)Math.Cos(angle) * 80f,
                        Position.Y + (float)Math.Sin(angle) * 80f,
                        (float)Math.Cos(angle) * 20f * ((float)Math.Cos(TimeAlive) + 10f) * Main.random.Next(2),
                        (float)Math.Sin(angle) * 20f * ((float)Math.Cos(TimeAlive) + 10f) * Main.random.Next(2),
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0f,
                        1f,
                        1f + ((float)Main.random.NextDouble() / 20f),
                        TeamIndex,
                        23,
                        Color.Blue,
                        Color.HotPink));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(Main.blur,
            //    new Rectangle(
            //        (int)(Position.X - Size / 2f),
            //        (int)(Position.Y - Size / 2f),
            //        (int)(Size),
            //        (int)(Size)),
            //     Color.CornflowerBlue * 2f);

            float red;
            float green;
            float blue;
            float alpha;

            for (int i = 0; i < Quality; i++)
            {
                red = 255f - i / (float)Quality * 255f;
                green = i / (float)Quality * 128f;
                blue = i / (float)Quality * 256f;
                alpha = (float)(Math.Cos(i / (Radius * 2) * MathHelper.Pi + 1f) / 2f);

                Polygon.SetScale(i / (float)Quality);
                Polygon.Rotate(0.01f, Enums.Axis.Z);
                Polygon.ApplyTransforms();
                Polygon.Draw(spriteBatch, Color.FromNonPremultiplied(
                    (int)(red * 0.1f),
                    (int)(green * 0.75f),
                    (int)(blue),
                    (int)(255 * ((float)i / Quality)))
                    * alpha, 6f);
            }
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}