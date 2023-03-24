using Microsoft.Xna.Framework;
using System;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Warp : Spark
    {
        public Warp()
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y)
            : base(x, y)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, emberColour)
        {
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour, Color fadeColour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, emberColour, fadeColour)
        {            
            WarpStrength = 1f;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour, Color fadeColour, float warpStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, emberColour, fadeColour)
        {
            WarpStrength = warpStrength;
        }
        public Warp(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex, int size, Color colour, Color emberColour, Color fadeColour, float warpStrength, SpaceObject origin)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, teamIndex, size, colour, emberColour, fadeColour)
        {
            Origin = origin;
            WarpStrength = warpStrength;
        }

        SpaceObject Origin;
        float WarpStrength;

        public override void Update(float delta)
        {
            Vector2 direction = this.Position - Origin.Position;
            float warpScale = (float)Math.Sin(((TimeAlive / MaxLifespan) - 0.5f) * Math.PI) + -1f;
            float angle = (float)Math.Atan2(direction.Y, direction.X);

            Acceleration += new Vector2(
                (float)Math.Cos(angle),
                (float)Math.Sin(angle)) * 30f * WarpStrength * (1f - (TimeAlive / MaxLifespan)) * warpScale;

            base.Update(delta);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}
