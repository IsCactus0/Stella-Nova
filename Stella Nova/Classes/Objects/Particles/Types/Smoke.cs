using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Smoke : Blur
    {
        public Smoke()
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y)
            : base(x, y)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color fadeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, fadeColour)
        {
            WindStrength = 1f;
        }
        public Smoke(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color fadeColour, float windStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, fadeColour)
        {
            WindStrength = windStrength;
        }

        public float WindStrength;

        public override void Update(float delta)
        {
            float angle = (float)Main.openSimplexNoise.Evaluate(
                Position.X / 100f,
                Position.Y / 100f,
                Main.NoiseOffset) * MathHelper.TwoPi;

            Acceleration += new Vector2(
                (float)Math.Cos(angle),
                (float)Math.Sin(angle)) * 500f * WindStrength;

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            int scale = (int)(Size * (1f - TimeAlive / MaxLifespan));
            Color fadedColour = Color.Lerp(Colour, FadeColour, 1f - CalculateFade());
            spriteBatch.Draw(Main.blur,
                new Rectangle(
                    (int)(Position.X - (scale / 2f)),
                    (int)(Position.Y - (scale / 2f)),
                    scale, scale),
                fadedColour * CalculateFade());
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}