using Microsoft.Xna.Framework;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Lithium : Ore
    {
        public Lithium()
        {
            Symbol = "Li";
            Colour = Color.Lavender;
            Mass = 0.534f;
        }
        public Lithium(float x, float y)
            : base(x, y)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
            Mass = 0.534f;
        }
        public Lithium(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
            Mass = 0.534f;
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
            Mass = 0.534f;
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
            Mass = 0.534f;
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
            Mass = 0.534f;
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
            Mass = 0.534f;
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
        }
        public Lithium(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
        : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Symbol = "Li";
            Colour = Color.Lavender;
        }
    }
}