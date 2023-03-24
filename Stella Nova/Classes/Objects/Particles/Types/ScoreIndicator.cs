using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using System;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class ScoreIndicator : Indicator
    {
        public ScoreIndicator()
            : base()
        {
            Mass = float.PositiveInfinity;
        }
        public ScoreIndicator(float x, float y)
            : base(x, y)
        {
            Mass = float.PositiveInfinity;
        }
        public ScoreIndicator(float x, float y, float vx, float vy) 
            : base(x, y, vx, vy)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, text)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text, float scale)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, text, scale)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text, float scale, Color colour) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, text, scale, colour)
        {

        }
        public ScoreIndicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text, float scale, Color colour, SpriteFont font)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan, text, scale, colour, font)
        {
        }

        public override void Destroy()
        {
            PlayerManager.player.Score += int.Parse(Text);
            UIManager.ScoreScale = 1f;
            UIManager.ScoreHighlight = Colour;

            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (TimeAlive < MaxLifespan)
                TimeAlive += delta;

            this.Angle += AngularVelocity * delta;

            Vector2 target = new Vector2(Main.camera.X, Main.camera.Y - Main.camera.BoundingBox.Height / 2f + 48);
            float distance = Vector2.Distance(target, Position);
            this.Position += Vector2.Normalize(target - Position) * (10f * Math.Abs(1f - CalculateFade()) * (distance + 500f)) * delta;

            if (Vector2.Distance(this.Position, target) < 80f)
                this.Destroy();

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Vector2 textSize = Font.MeasureString(Text) * Scale * CalculateScale();
            spriteBatch.DrawString(Font, Text, Position - (textSize / 2f), Colour, Angle, Vector2.Zero, Scale * CalculateScale(), SpriteEffects.None, 0);
        }
    }
}