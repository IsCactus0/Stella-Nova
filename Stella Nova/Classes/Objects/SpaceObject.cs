using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects
{
    public abstract class SpaceObject
    {
        public SpaceObject()
        {
            Position = Vector2.Zero;
            Velocity = Vector2.Zero;
            Acceleration = Vector2.Zero;
            Angle = 0;
            AngularVelocity = 0;
            AngularAcceloration = 0;
            Mass = 100;
            Friction = 1f;
        }
        public SpaceObject(float x, float y)
        {
            Position = new Vector2(x, y);
            Velocity = Vector2.Zero;
            Acceleration = Vector2.Zero;
            Angle = 0;
            AngularVelocity = 0;
            AngularAcceloration = 0;
            Mass = 100;
            Friction = 1f;
        }
        public SpaceObject(float x, float y, float vx, float vy)
        {
            Position = new Vector2(x, y);
            Velocity = new Vector2(vx, vy);
            Acceleration = Vector2.Zero;
            Angle = 0;
            AngularVelocity = 0;
            AngularAcceloration = 0;
            Mass = 100;
            Friction = 1f;
        }
        public SpaceObject(float x, float y, float vx, float vy, float ax, float ay)
        {
            Position = new Vector2(x, y);
            Velocity = new Vector2(vx, vy);
            Acceleration = new Vector2(ax, ay);
            Angle = 0;
            AngularVelocity = 0;
            AngularAcceloration = 0;
            Mass = 100;
            Friction = 1f;
        }
        public SpaceObject(float x, float y, float vx, float vy, float ax, float ay, float angle)
        {
            Position = new Vector2(x, y);
            Velocity = new Vector2(vx, vy);
            Acceleration = new Vector2(ax, ay);
            Angle = angle;
            AngularVelocity = 0;
            AngularAcceloration = 0;
            Mass = 100;
            Friction = 1f;
        }
        public SpaceObject(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
        {
            Position = new Vector2(x, y);
            Velocity = new Vector2(vx, vy);
            Acceleration = new Vector2(ax, ay);
            Angle = angle;
            AngularVelocity = vangle;
            AngularAcceloration = 0;
            Mass = 100;
            Friction = 1f;
        }
        public SpaceObject(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
        {
            Position = new Vector2(x, y);
            Velocity = new Vector2(vx, vy);
            Acceleration = new Vector2(ax, ay);
            Angle = angle;
            AngularVelocity = vangle;
            AngularAcceloration = aangle;
            Mass = 100;
            Friction = 1f;
        }
        public SpaceObject(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
        {
            Position = new Vector2(x, y);
            Velocity = new Vector2(vx, vy);
            Acceleration = new Vector2(ax, ay);
            Angle = angle;
            AngularVelocity = vangle;
            AngularAcceloration = aangle;
            Mass = mass;
            Friction = 1f;
        }
        public SpaceObject(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
        {
            Position = new Vector2(x, y);
            Velocity = new Vector2(vx, vy);
            Acceleration = new Vector2(ax, ay);
            Angle = angle;
            AngularVelocity = vangle;
            AngularAcceloration = aangle;
            Mass = mass;
            Friction = friction;
        }

        public Polygon Polygon;
        public Vector2 Position;
        public Vector2 Velocity;
        public Vector2 Acceleration;
        public float Angle;
        public float AngularVelocity;
        public float AngularAcceloration;
        public float Mass;
        public float Friction;
        public float TimeAlive;
        public SpaceObject Parent;

        public abstract List<Vector2> GenerateShape();
        public abstract void FindCollisions();
        public virtual void CheckBounds()
        {
            // if (Polygon.Rectangle.Location.X + Polygon.Rectangle.Width < 0)
            //     Position.X += Main.graphics.PreferredBackBufferWidth + Polygon.Rectangle.Width;
            // if (Polygon.Rectangle.Location.X > Main.graphics.PreferredBackBufferWidth)
            //     Position.X -= Main.graphics.PreferredBackBufferWidth + Polygon.Rectangle.Width;
            // if (Polygon.Rectangle.Location.Y + Polygon.Rectangle.Height < 0)
            //     Position.Y += Main.graphics.PreferredBackBufferHeight + Polygon.Rectangle.Height;
            // if (Polygon.Rectangle.Location.Y > Main.graphics.PreferredBackBufferHeight)
            //     Position.Y -= Main.graphics.PreferredBackBufferHeight + Polygon.Rectangle.Height;
        }
        public abstract void Destroy();
        public virtual void Update(float delta)
        {
            TimeAlive += delta;
            FindCollisions();

            if (Parent is null)
            {
                AngularVelocity += AngularAcceloration * delta;
                AngularVelocity *= (float)Math.Pow(Friction * (0.05f / Mass), delta);
                Angle += AngularVelocity * delta;
                Polygon.Yaw = Angle;
                Polygon.ApplyTransforms();

                Velocity += Acceleration * delta;
                Velocity *= (float)Math.Pow(Friction, delta);
                Position += Velocity * delta;
                Polygon.Origin = new Vector3(Position.X, Position.Y, 0f);

                Acceleration = Vector2.Zero;
                AngularAcceloration = 0f;

                CheckBounds();
            }
            else
            {
                Position = Parent.Position + new Vector2(Polygon.Offset.X, Polygon.Offset.Y);
                Polygon.Origin = Parent.Polygon.Origin;
                Polygon.ApplyTransforms();
            }
        }
        public virtual void SetParent(SpaceObject parent)
        {
            Polygon.Offset.X = Position.X - parent.Position.X;
            Polygon.Offset.Y = Position.Y - parent.Position.Y;
            Parent = parent;
        }
        public virtual void RemoveParent()
        {
            Polygon.Translate(Parent.Position.X - Position.X, Parent.Position.Y - Position.Y);
            Parent = null;
        }
        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract SpaceObject Clone();
    }
}