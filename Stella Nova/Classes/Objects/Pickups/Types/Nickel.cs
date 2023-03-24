using Microsoft.Xna.Framework;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Nickel : Ore
    {
        public Nickel()
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
            Mass = 8.9f;
        }
        public Nickel(float x, float y) 
            : base(x, y)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
            Mass = 8.9f;
        }
        public Nickel(float x, float y, float vx, float vy) 
            : base(x, y, vx, vy)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
            Mass = 8.9f;
        }
        public Nickel(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
            Mass = 8.9f;
        }
        public Nickel(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
            Mass = 8.9f;
        }
        public Nickel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
            Mass = 8.9f;
        }
        public Nickel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
            Mass = 8.9f;
        }
        public Nickel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
        }
        public Nickel(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Symbol = "Ni";
            Colour = Color.DarkKhaki;
        }
    }
}