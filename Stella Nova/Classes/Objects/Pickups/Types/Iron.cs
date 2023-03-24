using Microsoft.Xna.Framework;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Iron : Ore
    {
        public Iron()
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
            Mass = 7.874f;
        }
        public Iron(float x, float y)
            : base(x, y)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
            Mass = 7.874f;
        }
        public Iron(float x, float y, float vx, float vy) 
            : base(x, y, vx, vy)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
            Mass = 7.874f;
        }
        public Iron(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
            Mass = 7.874f;
        }
        public Iron(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
            Mass = 7.874f;
        }
        public Iron(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
            Mass = 7.874f;
        }
        public Iron(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
            Mass = 7.874f;
        }
        public Iron(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
        }
        public Iron(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Symbol = "Fe";
            Colour = Color.RosyBrown;
        }
    }
}