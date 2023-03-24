using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;

namespace Stella_Nova.Classes.Objects.UI
{
    public delegate void Select();
    public class MenuItem
    {
        public MenuItem(string text, SpriteFont font, Color selectedFontColour)
        {
            Text = text;
            FontSize = 0.4f;
            SelectedFontSize = 0.4f;
            Font = font;
            FontColour = Color.White;
            SelectedFontColour = selectedFontColour;
        }

        public string Text;
        public float FontSize;
        public float SelectedFontSize;
        public SpriteFont Font;
        public event Select Select;
        public Color FontColour;
        public Color SelectedFontColour;

        public virtual void Draw(SpriteBatch spriteBatch, bool selected, bool hovering, Vector2 offset)
        {
            if (hovering) spriteBatch.DrawString(Font, $"| {Text}", offset, SelectedFontColour, 0f, Vector2.Zero, SelectedFontSize, SpriteEffects.None, 0f);
            else if (selected) spriteBatch.DrawString(Font, $"| {Text}", offset, Color.Gold, 0f, Vector2.Zero, SelectedFontSize, SpriteEffects.None, 0f);
            else spriteBatch.DrawString(Font, Text, offset, FontColour, 0f, Vector2.Zero, FontSize, SpriteEffects.None, 0f);
        }
        public virtual void Activate()
        {
            Select?.Invoke();
        }
        public virtual void Reset()
        {

        }
    }
}