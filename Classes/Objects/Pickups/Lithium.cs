using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Pickups
{
    public class Lithium : Pickup
    {
        public Lithium()
        {
            Polygon = new Polygon(Vector3.Zero, GenerateShape());            
        }
        public Lithium(float x, float y)
            : base(x, y)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Lithium(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }

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
            Polygon.Draw(spriteBatch, Color.PaleVioletRed, 3f);
        }
    }
}