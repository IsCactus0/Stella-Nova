using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Stella_Nova.Classes.Objects.Enemies
{
    public class Worm : Enemy
    {
        public Worm(float x, float y)
            : base(x, y)
        {
            Friction = 0.5f;
            Body = new KinematicArm(new Vector2(x, y), 56, 32, 32, true, Color.Peru, Color.SaddleBrown);
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public KinematicArm Body;

        public override void Update(float delta)
        {
            float angle = (float)Main.openSimplexNoise.Evaluate(
                Position.X / 10000f, Position.Y / 10000f,
                Main.NoiseOffset / 10000f) * MathHelper.TwoPi;

            Angle = angle + ((float)Math.Sin(TimeAlive) * MathHelper.PiOver2) - MathHelper.PiOver4;

            Acceleration += new Vector2(
                (float)Math.Cos(Angle),
                (float)Math.Sin(Angle)) * 100f;

            Body.Origin = Position;
            Body.Update(delta);

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Body.Draw(spriteBatch);
        }
    }
}
