using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Particles
{
    public class Particle : SpaceObject
    {
        public Particle()
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y)
            : base(x, y)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MaxLifespan = 20f;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MaxLifespan = maxLifespan;
            TeamIndex = -1;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }
        public Particle(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, int teamIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            MaxLifespan = maxLifespan;
            TeamIndex = teamIndex;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
            Polygon.Yaw = Angle;
        }

        public float MaxLifespan;
        public int TeamIndex;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(10, 3);
        }
        public override void Destroy()
        {
            ParticleManager.particles.Remove(this);
        }
        public override void Update(float delta)
        {
            if (TimeAlive >= MaxLifespan)
                Destroy();

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (TimeAlive >= 0)
                Polygon.Draw(spriteBatch, Color.White * CalculateFade());
        }
        public override void FindCollisions()
        {
        }
        public virtual float CalculateFade()
        {
            return 1f - (TimeAlive / MaxLifespan);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}