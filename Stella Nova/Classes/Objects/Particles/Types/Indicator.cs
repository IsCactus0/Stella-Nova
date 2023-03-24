using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Indicator : Particle
    {
        public Indicator()
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
            Mass = float.PositiveInfinity;
        }
        public Indicator(float x, float y)
            : base(x, y)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
            Mass = float.PositiveInfinity;
        }
        public Indicator(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
            Mass = float.PositiveInfinity;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
            Mass = float.PositiveInfinity;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
            Mass = float.PositiveInfinity;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
            Mass = float.PositiveInfinity;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
            Mass = float.PositiveInfinity;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            Text = "?";
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            Text = text;
            Scale = 1f;
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text, float scale)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            Text = text;
            Scale = scale;
            Colour = Color.Red;
            Font = UIManager.Roboto_LightItalic;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text, float scale, Color colour)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            Text = text;
            Scale = scale;
            Colour = colour;
            Font = UIManager.Roboto_LightItalic;
        }
        public Indicator(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, float maxLifespan, string text, float scale, Color colour, SpriteFont font)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, maxLifespan)
        {
            Text = text;
            Scale = scale;
            Colour = colour;
            Font = font;
        }

        public string Text;
        public float Scale;
        public Color Colour;
        public SpriteFont Font;

        public override void Update(float delta)
        {
            if (TimeAlive < MaxLifespan)
                TimeAlive += delta;

            Angle += AngularVelocity * delta;

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            float scale = CalculateScale();
            Vector2 textSize = Font.MeasureString(Text) * Scale * scale;
            spriteBatch.DrawString(Font, Text, Position - (textSize / 2f), Colour * CalculateFade(), Angle, Vector2.Zero, Scale * scale, SpriteEffects.None, 0);
        }
        public override float CalculateFade()
        {
            if (TimeAlive > MaxLifespan / 3f * 2f)
                return 1f - (TimeAlive - (2f * MaxLifespan / 3f)) / (MaxLifespan / 3f);
            else return 1f;
        }
        public float CalculateScale()
        {
            return (1f + (TimeAlive / MaxLifespan)) / 1.5f;
        }
    }
}