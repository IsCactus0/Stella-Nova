using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Entities.Types
{
    public class Blackhole : Entity
    {
        public Blackhole()
        {
            Radius = 1000;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius / 12f;
            GravityStrength = 3000000000f;
            Mass = float.PositiveInfinity;
            Health = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Blackhole(float x, float y)
            : base(x, y)
        {
            Radius = 500;
            EffectRadius = 100000;
            Detail = 128;
            Quality = 150;
            Speed = 10f;
            Size = Radius / 12f;
            GravityStrength = 30000000000f;
            Mass = float.PositiveInfinity;
            Health = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Mass = float.PositiveInfinity;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            ImmunityPeriod = float.PositiveInfinity;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = 200;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            EffectRadius = 100000;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int effectRadius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            EffectRadius = effectRadius;
            Detail = 128;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int effectRadius, int detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            EffectRadius = effectRadius;
            Detail = detail;
            Quality = Radius;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int effectRadius, int detail, int quality)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            EffectRadius = effectRadius;
            Detail = detail;
            Quality = quality;
            Speed = 50f;
            Size = Radius;
            GravityStrength = 10000000f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int effectRadius, int detail, int quality, float speed)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            EffectRadius = effectRadius;
            Detail = detail;
            Quality = quality;
            Speed = speed;
            Size = Radius;
            GravityStrength = 10000000f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int effectRadius, int detail, int quality, float speed, float size)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            EffectRadius = effectRadius;
            Detail = detail;
            Quality = quality;
            Speed = speed;
            Size = size;
            GravityStrength = 10000000f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Blackhole(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int teamIndex, float health, float maxHealth, float immunityPeriod, int radius, int effectRadius, int detail, int quality, float speed, float size, float gravityStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, teamIndex, health, maxHealth, immunityPeriod)
        {
            Radius = radius;
            EffectRadius = effectRadius;
            Detail = detail;
            Quality = quality;
            Speed = speed;
            Size = size;
            GravityStrength = gravityStrength;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public int Radius;
        public int Detail;
        public int Quality;
        public int EffectRadius;
        public float Speed;
        public float Size;
        public float GravityStrength;

        private float offsetX;
        private float offsetY;

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
            List<SpaceObject> spaceObjects = AsteroidManager.FindAll(Position, EffectRadius).Cast<SpaceObject>()
                .Concat(EntityManager.FindAll(Position, EffectRadius))
                .Concat(ParticleManager.FindAll(Position, EffectRadius))
                .Concat(PickupManager.FindAll(Position, EffectRadius))
                .Concat(ProjectileManager.FindAll(Position, EffectRadius)).ToList();

            if (Vector2.Distance(PlayerManager.player.Position, Position) <= EffectRadius)
                spaceObjects.Add(PlayerManager.player);

            foreach (SpaceObject spaceObject in spaceObjects)
            {
                if (spaceObject.Mass <= 0 || spaceObject.Mass >= float.PositiveInfinity)
                    continue;

                Vector2 dir = Position - spaceObject.Position;
                float distance = dir.Length();

                if (distance > 10000)
                    continue;
                else if (distance <= Radius)
                {
                    spaceObject.Destroy();
                    if (spaceObject is Projectile)
                        spaceObject.Position.X = float.NegativeInfinity;
                }
                else
                {
                    dir /= distance;
                    float strength = ((GravityStrength / (distance * distance)) / spaceObject.Mass);
                    spaceObject.Acceleration += dir * strength;
                }
            }
        }
        public override void Update(float delta)
        {
            offsetX += delta / Radius * 10f;
            offsetY += delta / Radius * 10f;

            Polygon.OriginalVertices = new List<Vector3>();
            foreach (Vector2 vertice in GenerateShape())
                Polygon.OriginalVertices.Add(new Vector3(vertice.X, vertice.Y, 0));
            
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            float lineSize = Radius / 7f;
            float scale = ((Radius - lineSize / 2f) / Radius);

            Polygon.SetScale(scale);
            Polygon.ApplyTransforms();
            Polygon.Draw(spriteBatch, Color.Black, lineSize);
            Polygon.Rotate(0.02f, Enums.Axis.Z);
            Polygon.ApplyTransforms();
            Polygon.Draw(spriteBatch, Color.Black, lineSize);

            spriteBatch.Draw(Main.blur,
                new Rectangle(
                    (int)(Position.X - Radius * 2f),
                    (int)(Position.Y - Radius * 2f),
                    (int)(Radius * 4f),
                    (int)(Radius * 4f)),
                Color.Black);

            spriteBatch.Draw(Main.circle,
                new Rectangle(
                    (int)(Position.X - Radius * scale),
                    (int)(Position.Y - Radius * scale),
                    (int)(Radius * 2f * scale),
                    (int)(Radius * 2f * scale)),
                Color.Black);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}