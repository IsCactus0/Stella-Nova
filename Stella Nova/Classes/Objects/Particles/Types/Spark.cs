using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Spark : Smoke
    {
        public Spark()
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y)
            : base(x, y)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            FadeColour = Color.Maroon;
            EmberColour = Color.LightGoldenrodYellow;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size)
        {
            EmberColour = Color.LightGoldenrodYellow;
            FadeColour = Color.Maroon;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour)
        {
            EmberColour = Color.LightGoldenrodYellow;
            FadeColour = Color.Maroon;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, emberColour)
        {
            EmberColour = emberColour;
            FadeColour = Color.Maroon;
            WindStrength = 1f;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour, Color fadeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, fadeColour)
        {
            EmberColour = emberColour;
            FadeColour = fadeColour;
        }
        public Spark(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour, Color fadeColour, float windStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, fadeColour, windStrength)
        {
            EmberColour = emberColour;
            FadeColour = fadeColour;
        }

        public Color EmberColour;

        public override void Update(float delta)
        {
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            float fade = CalculateFade();
            Color fadedColour = Color.Lerp(EmberColour, FadeColour, 1f - fade);
            spriteBatch.Draw(Main.basic, new Rectangle((int)Position.X, (int)Position.Y, 2, 2), fadedColour);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}