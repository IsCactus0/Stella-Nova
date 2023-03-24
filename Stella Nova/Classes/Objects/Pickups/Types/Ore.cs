using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Ore : Pickup
    {
        public Ore()
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y)
            : base(x, y)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Ore(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Symbol = "";
            Colour = Color.White;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }

        public string Symbol;
        public Color Colour;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Asteroid(8, 3, 7f, Main.random.Next(3, 7), Main.openSimplexNoise, Main.random);
        }
        public override void Update(float delta)
        {
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Colour, 3f);
        }
    }
}
