using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using System;

namespace Stella_Nova.Classes.Objects
{
    public abstract class Pickup : SpaceObject
    {
        public Pickup()
        {
            Friction = 0.8f;
            Mass = 10f;
        }
        public Pickup(float x, float y)
            : base(x, y)
        {
            Friction = 0.8f;
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Friction = 0.8f;
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Friction = 0.8f;
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Friction = 0.8f;
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Friction = 0.8f;
            Mass = 10f;
        }
        public Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Friction = 0.8f;
            Mass = 10f;
        }
        protected Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Friction = 0.8f;
        }
        protected Pickup(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }

        public override void FindCollisions()
        {

        }
        public virtual void OnPickup(Player player)
        {
            player.Pickups.Add(this);
            PickupManager.pickups.Remove(this);
        }
        public override void Destroy()
        {
            PickupManager.pickups.Remove(this);
        }
        public override void Update(float delta)
        {
            // SpaceObject Target = PlayerManager.player;
            // if (!(Target is null))
            // {
            //     float distance = Vector2.Distance(Position, Target.Position);
            //     if (distance < ((Player)Target).PickupRange * 32f)
            //         Acceleration += (Target.Position - Position) * 100000f / (distance * distance);
            // }

            base.Update(delta);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}