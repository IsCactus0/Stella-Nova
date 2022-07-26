using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Pickups
{
    public class Magnetite : Pickup
    {
        public Magnetite()
        {
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
            
        }
        public Magnetite(float x, float y)
            : base(x, y)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Magnetite(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }

        public override List<Vector2> GenerateShape()
        {
            int scale = Main.random.Next(1, 4);
            
            switch (Main.random.Next(4))
            {
                case 0:
                    return new List<Vector2>()
                    {
                        new Vector2( 3f,  0f) * scale,
                        new Vector2( 2f,  1f) * scale,
                        new Vector2(-2f,  1f) * scale,
                        new Vector2(-3f,  0f) * scale,
                        new Vector2(-2f, -1f) * scale,
                        new Vector2( 2f, -1f) * scale
                    };
                case 1:
                    return new List<Vector2>()
                    {
                        new Vector2( 6.17f,  5.38f) * scale,
                        new Vector2(  2.2f,  8.77f) * scale,
                        new Vector2( -1.9f,  3.25f) * scale,
                        new Vector2(-1.42f,  0.45f) * scale,
                        new Vector2(-3.38f,  1.19f) * scale,
                        new Vector2( -3.1f,  1.53f) * scale,
                        new Vector2(-0.36f, -4.15f) * scale,
                        new Vector2( 3.23f, -4.27f) * scale,
                        new Vector2( 7.04f, -1.23f) * scale,
                        new Vector2( 6.71f,  0.45f) * scale,
                        new Vector2( 5.07f, -0.07f) * scale,
                    };
                case 2:
                    return new List<Vector2>()
                    {
                        new Vector2( 3.72f,   7.4f) * scale,
                        new Vector2(-0.96f,  4.45f) * scale,
                        new Vector2(-2.13f, -3.27f) * scale,
                        new Vector2( 1.08f,  -3.8f) * scale,
                        new Vector2(-0.83f, -4.85f) * scale,
                        new Vector2(  4.5f,  3.58f) * scale,
                    };
                default:
                    return Drawing.Asteroid(8, 3, 7f, Main.random.Next(3, 7), Main.openSimplexNoise, Main.random);
            }            
        }
        public override void Update(float delta)
        {
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Color.SlateGray, 4f);
        }
    }
}