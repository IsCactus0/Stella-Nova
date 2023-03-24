using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class AsteroidDebris : Particle
    {
        public AsteroidDebris()
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Mass = Radius;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public AsteroidDebris(float x, float y)
            : base(x, y)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Mass = Radius;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Mass = Radius;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Mass = Radius;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Mass = Radius;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Mass = Radius;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Mass = Radius;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = 8;
            Detail = 1;
            Roughness = Detail / Radius;
            Resolution = (int)(Radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, float radius)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = radius;
            Detail = 1;
            Roughness = Detail / radius;
            Resolution = (int)(radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, float radius, float detail)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = radius;
            Detail = detail;
            Roughness = detail / radius;
            Resolution = (int)(radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, float radius, float detail, float roughness)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = radius;
            Detail = detail;
            Roughness = roughness;
            Resolution = (int)(radius / 1.5f);
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, float radius, float detail, float roughness, int resolution)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = radius;
            Detail = detail;
            Roughness = roughness;
            Resolution = resolution;
            Colour = Color.White;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, float radius, float detail, float roughness, int resolution, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = radius;
            Detail = detail;
            Roughness = roughness;
            Resolution = resolution;
            Colour = colour;
            DustColour = Color.DimGray;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, float radius, float detail, float roughness, int resolution, Color colour, Color dustColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = radius;
            Detail = detail;
            Roughness = roughness;
            Resolution = resolution;
            Colour = colour;
            DustColour = dustColour;
            FadeColour = Color.Black;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public AsteroidDebris(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, float radius, float detail, float roughness, int resolution, Color colour, Color dustColour, Color fadeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Radius = radius;
            Detail = detail;
            Roughness = roughness;
            Resolution = resolution;
            Colour = colour;
            DustColour = dustColour;
            FadeColour = fadeColour;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public float Radius;
        public float Detail;
        public float Roughness;
        public int Resolution;
        public Color Colour;
        public Color DustColour;
        public Color FadeColour;

        public override void Update(float delta)
        {
            if (Radius > 10f && Main.random.Next(100) == 0)
            {
                float angle = (float)(Main.random.NextDouble() * Math.PI * 2f);
                Vector2 randomVelocity = new Vector2(
                        (float)Math.Cos(angle) * 40f,
                        (float)Math.Sin(angle) * 40f);

                ParticleManager.particles.Add(
                    new Blur(
                        Position.X + (float)Main.random.NextDouble() - 0.5f,
                        Position.Y + (float)Main.random.NextDouble() - 0.5f,
                        Velocity.X + randomVelocity.X,
                        Velocity.Y + randomVelocity.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f, 0.2f + (float)Main.random.NextDouble(), TeamIndex,
                        Main.random.Next(8, 12),
                        DustColour * CalculateFade(),
                        FadeColour));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Colour * CalculateFade());
        }
        public override List<Vector2> GenerateShape()
        {
            return Drawing.Asteroid(Radius, Detail, Roughness, Resolution, Main.openSimplexNoise, Main.random);
        }
        public override float CalculateFade()
        {
            if (TimeAlive > MaxLifespan * 2f / 3f)
                return 1f - (TimeAlive - (2f * MaxLifespan / 3f)) / (MaxLifespan / 3f);
            else return 1f;
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}