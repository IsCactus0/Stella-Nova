using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects
{
    public class KinematicJoint : SpaceObject
    {
        public KinematicJoint()
        {
            Friction = 1f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }
        public KinematicJoint(float x, float y)
            : base(x, y)
        {
            Friction = 0.5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public KinematicJoint(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Friction = 0.5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public KinematicJoint(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Friction = 0.5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public KinematicJoint(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Friction = 0.5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public KinematicJoint(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Friction = 0.5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public KinematicJoint(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Friction = 0.5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public KinematicJoint(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Friction = 0.5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public KinematicJoint(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>();
        }
        public override void FindCollisions()
        {
        }
        public override void Destroy()
        {
        }
        public override void Update(float delta)
        {
            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {

        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}