using Microsoft.Xna.Framework.Graphics;

namespace Stella_Nova.Classes.Objects.Abilities
{
    public abstract class Ability
    {
        public Ability()
        {
            isActive = false;
            UseTime = 1f;
            LastUsed = 0f;
        }
        public Ability(float useTime)
        {
            isActive = false;
            UseTime = useTime;
            LastUsed = 0f;
        }

        public bool isActive;
        public float UseTime;
        public float LastUsed;

        public abstract void Update(float delta, Entity origin);
        public abstract void Draw(SpriteBatch spritebatch, Entity origin);
        public abstract void DrawUI(SpriteBatch spritebatch);
        public virtual void Reset()
        {
            LastUsed = 0f;
        }
    }
}