using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Stella_Nova.Classes.Objects.Abilities
{
    public class WarpJump : Ability
    {
        public WarpJump()
        {

        }
        public WarpJump(float useTime)
            : base(useTime)
        {

        }

        public float ChargeTime;
        public float TravelDistance;

        public override void Update(float delta, Entity origin)
        {
            Vector2 direction = new Vector2((float)Math.Cos(origin.Angle), (float)Math.Sin(origin.Angle));
            origin.Position += direction * TravelDistance;
        }
        public override void Draw(SpriteBatch spritebatch, Entity origin)
        {
            
        }
        public override void DrawUI(SpriteBatch spritebatch)
        {
            throw new NotImplementedException();
        }
    }
}