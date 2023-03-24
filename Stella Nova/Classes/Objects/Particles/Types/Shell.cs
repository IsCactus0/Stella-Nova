using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Shell : Particle
    {
        public Shell()
        {

        }
        public Shell(float x, float y)
            : base(x, y)
        {

        }
        public Shell(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {

        }
        public Shell(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {

        }

        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>()
            {
                new Vector2(-5f, -2.5f),
                new Vector2( 5f, -2.5f),
                new Vector2( 7f, -1.5f),
                new Vector2( 9.5f, -1.5f),
                new Vector2( 9.5f,  1.5f),
                new Vector2( 7f,  1.5f),
                new Vector2( 5f,  2.5f),
                new Vector2(-5f,  2.5f),
            };
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Color.Tan * CalculateFade(), 1.2f);
        }
        public override float CalculateFade()
        {
            if (TimeAlive > MaxLifespan / 3f * 2f)
                return 1f - (TimeAlive - (2f * MaxLifespan / 3f)) / (MaxLifespan / 3f);
            else return 1f;
        }
    }
}