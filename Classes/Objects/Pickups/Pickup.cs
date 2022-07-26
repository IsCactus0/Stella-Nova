using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;

namespace Stella_Nova.Classes.Objects
{
    public abstract class Pickup : SpaceObject
    {
        public Pickup()
        {
            Mass = 10f;
        }
        public Pickup(float x, float y)
            : base(x, y)
        {
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Mass = 10f;
        }
        protected Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        protected Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }

        public override void FindCollisions()
        {
            if (Vector2.Distance(Position, PlayerManager.player.Position) <= PlayerManager.player.PickupRange)
                PlayerManager.player.Pickup(this);
        }
        public override void Destroy()
        {
            PickupManager.pickups.Remove(this);
        }
        public override void Update(float delta)
        {
            SpaceObject Target = PlayerManager.player;
            if (!(Target is null))
            {
                float distance = Vector2.Distance(Position, Target.Position) / 100f;
                Acceleration = (Target.Position - Position) * 10f / (distance * distance);
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Color.White);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}