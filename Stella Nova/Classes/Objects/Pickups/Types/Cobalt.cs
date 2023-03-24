using Microsoft.Xna.Framework;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Cobalt : Ore
    {
        public Cobalt()
            : base()
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
            Mass = 8.9f;
        }
        public Cobalt(float x, float y)
            : base(x, y)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
            Mass = 8.9f;
        }
        public Cobalt(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
            Mass = 8.9f;
        }
        public Cobalt(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
            Mass = 8.9f;
        }
        public Cobalt(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
            Mass = 8.9f;
        }
        public Cobalt(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
            Mass = 8.9f;
        }
        public Cobalt(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
            Mass = 8.9f;
        }
        public Cobalt(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
        }
        public Cobalt(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Symbol = "Co";
            Colour = Color.RoyalBlue;
        }
    }
}