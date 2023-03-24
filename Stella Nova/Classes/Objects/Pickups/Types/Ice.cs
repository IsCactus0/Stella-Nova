using Microsoft.Xna.Framework;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Ice : Ore
    {
        public Ice()
            : base()
        {
            Symbol = "H₂0";
            Colour = Color.LightSteelBlue;
            Mass = 1f;
        }
        public Ice(float x, float y) 
            : base(x, y)
        {
            Symbol = "H₂0";
            Mass = 1f;
            Colour = Color.LightSteelBlue;
        }
        public Ice(float x, float y, float vx, float vy) 
            : base(x, y, vx, vy)
        {
            Mass = 1f;
            Colour = Color.LightSteelBlue;
        }
        public Ice(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {
            Mass = 1f;
            Colour = Color.LightSteelBlue;
        }
        public Ice(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Mass = 1f;
            Colour = Color.LightSteelBlue;
        }
        public Ice(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Mass = 1f;
            Colour = Color.LightSteelBlue;
        }
        public Ice(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Mass = 1f;
            Colour = Color.LightSteelBlue;
        }
        public Ice(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Colour = Color.LightSteelBlue;
        }
        public Ice(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Colour = Color.LightSteelBlue;
        }
    }
}