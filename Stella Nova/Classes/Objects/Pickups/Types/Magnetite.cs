using Microsoft.Xna.Framework;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Magnetite : Ore
    {
        public Magnetite()
            : base()
        {
            Symbol = "Fe₃O₄";
            Colour = Color.SlateGray;
            Mass = 5.17f;
        }
        public Magnetite(float x, float y) 
            : base(x, y)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
            Mass = 5.17f;
        }
        public Magnetite(float x, float y, float vx, float vy) 
            : base(x, y, vx, vy)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
            Mass = 5.17f;
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
            Mass = 5.17f;
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
            Mass = 5.17f;
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
            Mass = 5.17f;
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
            Mass = 5.17f;
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
        }
        public Magnetite(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Symbol = "Fe3O4";
            Colour = Color.SlateGray;
        }
    }
}