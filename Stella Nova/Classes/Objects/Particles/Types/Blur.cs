using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Blur : Particle
    {
        public Blur()
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public Blur(float x, float y)
            : base(x, y)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Size = 12;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());

        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Colour = Color.White;
            FadeColour = Colour;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Colour = colour;
            FadeColour = colour;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }
        public Blur(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color fadeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            Colour = colour;
            FadeColour = fadeColour;
            Size = size;
            Glow = Main.blur;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            
        }

        public int Size;
        public Color Colour;
        public Color FadeColour;
        public Texture2D Glow;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(Size, 4);
        }
        public override void Update(float delta)
        {
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Color fadedColour = Color.Lerp(Colour, FadeColour, 1f - CalculateFade());
            spriteBatch.Draw(Main.blur,
                new Rectangle(
                    (int)(Position.X - (Size / 2f)),
                    (int)(Position.Y - (Size / 2f)),
                    Size, Size),
                fadedColour * CalculateFade());
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}