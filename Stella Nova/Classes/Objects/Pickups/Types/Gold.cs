using Microsoft.Xna.Framework;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;

namespace Stella_Nova.Classes.Objects.Pickups.Types
{
    public class Gold : Ore
    {
        public Gold()
            : base()
        {
            Symbol = "Au";
            Colour = Color.Gold;
            Mass = 19.32f;
        }
        public Gold(float x, float y)
            : base(x, y)
        {
            Symbol = "Au";
            Colour = Color.Gold;
            Mass = 19.32f;
        }
        public Gold(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Symbol = "Au";
            Colour = Color.Gold;
            Mass = 19.32f;
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Symbol = "Au";
            Colour = Color.Gold;
            Mass = 19.32f;
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Symbol = "Au";
            Colour = Color.Gold;
            Mass = 19.32f;
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Symbol = "Au";
            Colour = Color.Gold;
            Mass = 19.32f;
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Symbol = "Au";
            Colour = Color.Gold;
            Mass = 19.32f;
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Symbol = "Au";
            Colour = Color.Gold;
        }
        public Gold(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Symbol = "Au";
            Colour = Color.Gold;
        }

        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 0.005f))
                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + Main.random.Next(-6, 6),
                        Position.Y + Main.random.Next(-6, 6),
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 1f, 0.02f, 0, 20,
                        Color.Gold,
                        Color.LightGoldenrodYellow,
                        Color.Maroon));

            base.Update(delta);
        }
    }
}