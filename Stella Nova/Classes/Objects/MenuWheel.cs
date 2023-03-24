using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects
{
    public class MenuWheel
    {
        public MenuWheel(string text, SpriteFont smallFont, SpriteFont largeFont, Vector2 position)
        {
            Text = text;
            Selected = false;
            SmallFont = smallFont;
            LargeFont = largeFont;
            SubMenu = new List<MenuWheel>();
            Position = position;
        }

        public string Text;
        public bool Selected;
        public SpriteFont SmallFont;
        public SpriteFont LargeFont;
        public List<MenuWheel> SubMenu;
        public Vector2 Position;

        public void Draw(SpriteBatch spritebatch)
        {
            if (Selected) {
                if (!string.IsNullOrWhiteSpace(Text))
                {
                    Vector2 size = LargeFont.MeasureString("| " + Text) * 0.4f;
                    spritebatch.DrawString(LargeFont, "| " + Text, new Vector2(Position.X, Position.Y + size.Y / 2f), Color.Orange, 0f, new Vector2(Position.X, Position.Y + size.Y / 2f), 0.4f, SpriteEffects.None, 0);
                }
                
                foreach (MenuWheel subMenu in SubMenu)
                    subMenu.Draw(spritebatch);
            }
            else
            {
                Vector2 size = LargeFont.MeasureString(Text) * 0.3f;
                spritebatch.DrawString(LargeFont, Text, new Vector2(Position.X, Position.Y + size.Y / 2f), Color.White, 0f, new Vector2(Position.X, Position.Y + size.Y / 2f), 0.3f, SpriteEffects.None, 0);
            }
        }
        public void Next()
        {
            // If no options are selected...
            if (SubMenu.Count > 0 && !SubMenu.Any(t => t.Selected))
            {
                // ...select the first possible option.
                SubMenu[0].Selected = true;
                return;
            }

            int index = SubMenu.FindIndex(t => t.Selected);
            if (index < SubMenu.Count - 1)
            {
                SubMenu[index].Selected = false;
                SubMenu[index + 1].Selected = true;
            }
        }
        public void Previous()
        {
            // If no options are selected...
            if (SubMenu.Count > 0 && !SubMenu.Any(t => t.Selected))
            {
                // ...select the first possible option.
                SubMenu[0].Selected = true;
                return;
            }

            int index = SubMenu.FindIndex(t => t.Selected);
            if (index > 0)
            {
                SubMenu[index].Selected = false;
                SubMenu[index - 1].Selected = true;
            }
        }
    }
}