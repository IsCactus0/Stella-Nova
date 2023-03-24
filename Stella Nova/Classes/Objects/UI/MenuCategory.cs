using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.UI
{
    public class MenuCategory : MenuItem
    {
        public MenuCategory(string text, SpriteFont font, Color selectedFontColour)
            : base(text, font, selectedFontColour)
        {
            isBase = false;
            HoveredIndex = 0;
            SelectedIndex = -1;
            MenuItems = new List<MenuItem>();
        }

        public bool isBase;
        public int HoveredIndex;
        public int SelectedIndex;
        public List<MenuItem> MenuItems;

        public override void Draw(SpriteBatch spriteBatch, bool selected, bool hovering, Vector2 offset)
        {
            if (!isBase) base.Draw(spriteBatch, selected, hovering, offset);
            
            if (!selected)
                return;

            for (int i = 0; i < MenuItems.Count; i++)
            {
                float difference = (HoveredIndex - i);
                if (Math.Abs(difference) > 2)
                    continue;

                Vector2 fontSize = Font.MeasureString($"| {Text}");
                if (SelectedIndex == i || HoveredIndex == i)
                    fontSize *= SelectedFontSize;
                else fontSize *= FontSize;

                MenuItems[i].Draw(spriteBatch, SelectedIndex == i, HoveredIndex == i, offset + new Vector2(fontSize.X + 60f, -difference * fontSize.Y));
            }
        }
        public virtual void Navigate(Direction direction)
        {
            // If the menu already has an option selected navigate the selected menu...
            if (SelectedIndex >= 0)
            {
                if (MenuItems[SelectedIndex] is MenuCategory)
                {
                    if (direction == Direction.Left && ((MenuCategory)MenuItems[SelectedIndex]).SelectedIndex == -1)
                        SelectedIndex = -1;
                    else ((MenuCategory)MenuItems[SelectedIndex]).Navigate(direction);
                }                    
                return;
            }

            // If the current menu is being navigated...
            switch (direction)
            {
                case Direction.Up:
                    if (HoveredIndex > 0)
                        HoveredIndex--;
                    break;

                case Direction.Down:
                    if (HoveredIndex < MenuItems.Count - 1)
                        HoveredIndex++;
                    break;

                case Direction.Left:
                    SelectedIndex = -1;

                    break;
                case Direction.Right:
                    if (!(MenuItems[HoveredIndex] is MenuCategory))
                        MenuItems[HoveredIndex].Activate();
                    else SelectedIndex = HoveredIndex;
                    break;
            }
        }
        public override void Reset()
        {
            if (SelectedIndex >= 0)
                MenuItems[SelectedIndex].Reset();

            Navigate(Direction.Left);
            HoveredIndex = 0;
        }
    }
}