using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Fire : Blur
    {
        public Fire()
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y)
            : base(x, y)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size)
        {
            EmberColour = Color.LightGoldenrodYellow;
            FadeColour = Color.Maroon;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour)
        {
            EmberColour = Color.LightGoldenrodYellow;
            FadeColour = Color.Maroon;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, emberColour)
        {
            EmberColour = emberColour;
            FadeColour = Color.Maroon;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour, Color fadeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, fadeColour)
        {
            EmberColour = emberColour;
            FadeColour = fadeColour;
            WindStrength = 1f;
        }
        public Fire(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour, Color fadeColour, float windStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, fadeColour)
        {
            EmberColour = emberColour;
            FadeColour = fadeColour;
            WindStrength = windStrength;
        }

        public Color EmberColour;
        public float WindStrength;

        public override void Update(float delta)
        {
            float angle = (float)Main.openSimplexNoise.Evaluate(
                Position.X / 100f,
                Position.Y / 100f,
                Main.NoiseOffset) * MathHelper.TwoPi;

            if (TimeAlive != 0)
                Acceleration += new Vector2(
                    (float)Math.Cos(angle),
                    (float)Math.Sin(angle)) * 500f * WindStrength;

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            Color fadedColour = Color.Lerp(EmberColour, FadeColour, 1f - CalculateFade());
            Drawing.DrawLine(spriteBatch, Position - Vector2.One, Position + Vector2.One, fadedColour, 3f);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}