using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Rope : Particle
    {
        public Rope()
        {
        }
        public Rope(float x, float y)
            : base(x, y)
        {
        }
        public Rope(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
        }
        public Rope(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
        }
        public Rope(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
        }
        public Rope(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
        }
        public Rope(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
        }
        public Rope(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
        }
        public Rope(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
        }

        public KinematicArm Segments;

        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>() { Position };
        }
        public override void Destroy()
        {
            base.Destroy();
        }
        public override void FindCollisions()
        {
            base.FindCollisions();
        }
        public override void Update(float delta)
        {
            Segments.Limit(this.Position);
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Segments.Draw(spriteBatch);
        }
        public override SpaceObject Clone()
        {
            return (Rope)MemberwiseClone();
        }
    }
}
