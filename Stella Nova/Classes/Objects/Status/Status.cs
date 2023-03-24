using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Objects.Entities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Effects
{
    public abstract class Status
    {
        public Status()
        {
            isActive = true;
            UseTime = 1f;
            LastUsed = 0f;
            MaxTime = 10f;
        }
        public Status(float useTime)
        {
            isActive = true;
            LastUsed = 0f;
            UseTime = useTime;
            MaxTime = 10f;
        }

        public bool isActive;
        public float LastUsed;
        public float UseTime;
        public float Time;
        public float MaxTime;
        public Polygon Polygon;

        public virtual List<Vector2> GenerateShape()
        {
            return new List<Vector2>();
        }
        public virtual void Update(float delta, Entity origin)
        {
            Time += delta;
            if (Time > MaxTime)
                isActive = false;
        }
        public abstract void Draw(SpriteBatch spritebatch, Entity origin);
        public abstract void DrawUI(SpriteBatch spritebatch);
        public virtual void Reset()
        {
            isActive = true;
            Time = 0f;
            LastUsed = 0f;
            Polygon.ResetVertices();
        }
    }
}