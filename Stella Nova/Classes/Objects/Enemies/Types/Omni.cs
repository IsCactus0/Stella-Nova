using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Enemies.Types
{
    public class Omni : Enemy
    {
        public Omni(float x, float y)
            : base(x, y)
        {
            Polygon = new Polygon(new Vector3(x, y, 0));
        }

        public float moveSpeed = 10000;
        public float sightRange = 200;

        public override void Update(float delta)
        {
            List<Entity> others = EntityManager.FindAll(Position, sightRange);
            others.Remove(this);

            foreach (Entity other in others)
            {
                Vector2 dir = other.Position - this.Position;
                float dist = dir.Length();
                this.Acceleration += moveSpeed * (dir / dist) / (dist * dist);
            }

            if (Acceleration.Length() > 300)
            {
                Acceleration.Normalize();
                Acceleration *= 300f;
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 64, (int)Position.Y - 64, 128, 128), Color.White);
        }
    }
}