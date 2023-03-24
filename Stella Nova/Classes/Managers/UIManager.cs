using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.UI;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Managers
{
    public class UIManager : DrawableGameComponent
    {
        public static Color menuColour;
        public static SpriteBatch spriteBatch;
        public static List<DisplayMode> displayModes;
        public static SpaceObject menuCinematicTarget;

        public static int selectedDisplayMode;
        public static float menuCinematicLastChanged;
        public static float menuCinematicChangeTime;
        public static float menuCinematicFadeTime;
        public static bool menuCinematicHasChanged;

        public static float ScoreScale;
        public static Color ScoreHighlight;
        public static float SunAngle;

        public static MenuCategory PauseMenu;
        public static MenuCategory SettingsMenu;
        public static MenuCategory ColoursMenu;
        public static MenuCategory ResolutionMenu;
        public static MenuCategory ControlsMenu;

        public static SpriteFont Roboto_Light;
        public static SpriteFont Roboto_LightItalic;
        public static SpriteFont Roboto_Regular;
        public static SpriteFont Roboto_Medium;

        public UIManager(Game game) : base(game)
        {
            displayModes = new List<DisplayMode>();
            foreach (DisplayMode displayMode in GraphicsAdapter.DefaultAdapter.SupportedDisplayModes)
                displayModes.Add(displayMode);
            selectedDisplayMode = displayModes.Count - 1;

            menuColour = Color.FromNonPremultiplied(250, 169, 0, 256);
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            menuCinematicLastChanged = 5f;
            menuCinematicChangeTime = 5f;
            menuCinematicFadeTime = menuCinematicChangeTime / 10f;
            menuCinematicHasChanged = false;
            ScoreScale = 0.75f;
            ScoreHighlight = menuColour;

            Roboto_Light = game.Content.Load<SpriteFont>("Fonts/Roboto-Light");
            Roboto_LightItalic = game.Content.Load<SpriteFont>("Fonts/Roboto-LightItalic");
            Roboto_Regular = game.Content.Load<SpriteFont>("Fonts/Roboto-Regular");
            Roboto_Medium = game.Content.Load<SpriteFont>("Fonts/Roboto-Medium");

            PauseMenu = new MenuCategory("", Roboto_Medium, menuColour) { isBase = true };
            SettingsMenu = new MenuCategory("SETTINGS", Roboto_Medium, menuColour);
            ColoursMenu = new MenuCategory("COLOURS", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            ResolutionMenu = new MenuCategory("RESOLUTION", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            ControlsMenu = new MenuCategory("CONTROLS", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));

            MenuItem ContinueOption = new MenuItem("CONTINUE", Roboto_Medium, menuColour);
            MenuItem ExitOption = new MenuItem("EXIT", Roboto_Medium, menuColour);
            MenuItem colourMenuItem0 = new MenuItem($"DEUTERANOMALY", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            MenuItem colourMenuItem1 = new MenuItem($"PROTANOMALY", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            MenuItem colourMenuItem2 = new MenuItem($"PROTANOPIA", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            MenuItem colourMenuItem3 = new MenuItem($"DEUTERANOPIA", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            MenuItem colourMenuItem4 = new MenuItem($"TRITANOPIA", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            MenuItem colourMenuItem5 = new MenuItem($"TRITANOMALY", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
            MenuItem colourMenuItem6 = new MenuItem($"ACHROMATOPSIA", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));

            PauseMenu.MenuItems.Add(ContinueOption);
            PauseMenu.MenuItems.Add(SettingsMenu);
            PauseMenu.MenuItems.Add(ExitOption);

            SettingsMenu.MenuItems.Add(ColoursMenu);
            SettingsMenu.MenuItems.Add(ResolutionMenu);
            SettingsMenu.MenuItems.Add(ControlsMenu);

            ColoursMenu.MenuItems.Add(colourMenuItem0);
            ColoursMenu.MenuItems.Add(colourMenuItem1);
            ColoursMenu.MenuItems.Add(colourMenuItem2);
            ColoursMenu.MenuItems.Add(colourMenuItem3);
            ColoursMenu.MenuItems.Add(colourMenuItem4);
            ColoursMenu.MenuItems.Add(colourMenuItem5);
            ColoursMenu.MenuItems.Add(colourMenuItem6);

            for (int i = 0; i < displayModes.Count; i++)
            {
                MenuItem menuResolutionItem = new MenuItem($"{displayModes[i].Width}x{displayModes[i].Height}", Roboto_Medium, Color.FromNonPremultiplied(250, 169, 0, 256));
                menuResolutionItem.Select += EventResolutionChanged;
                ResolutionMenu.MenuItems.Add(menuResolutionItem);
            }

            // Link event methods...
            ExitOption.Select += EventExit;
            ContinueOption.Select += EventContinue;
            colourMenuItem0.Select += EventAccentColourChanged;
            colourMenuItem1.Select += EventAccentColourChanged;
            colourMenuItem2.Select += EventAccentColourChanged;
            colourMenuItem3.Select += EventAccentColourChanged;
            colourMenuItem4.Select += EventAccentColourChanged;
            colourMenuItem5.Select += EventAccentColourChanged;
            colourMenuItem6.Select += EventAccentColourChanged;

            SetResolution(displayModes[selectedDisplayMode].Width, displayModes[selectedDisplayMode].Height);
        }
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
        public static void SetResolution(int width, int height)
        {
            for (int i = 0; i < displayModes.Count; i++)
            {
                if (displayModes[i].Width == width && displayModes[i].Height == height)
                {
                    selectedDisplayMode = i;
                    Main.graphics.PreferredBackBufferWidth = width;
                    Main.graphics.PreferredBackBufferHeight = height;
                    Main.graphics.ApplyChanges();

                    Main.renderTarget = new RenderTarget2D(Main.graphics.GraphicsDevice, Main.graphics.PreferredBackBufferWidth, Main.graphics.PreferredBackBufferHeight);
                    Main.camera.AspectRatio = (float)Main.graphics.PreferredBackBufferWidth / Main.graphics.PreferredBackBufferHeight;
                    Main.camera.Scale = Main.graphics.PreferredBackBufferHeight / 1080f;
                    Main.camera.Viewport = Main.graphics.GraphicsDevice.Viewport;
                }
            }
        }
        public static void EventContinue()
        {
            PauseMenu.Reset();
            Main.gameStage = GameStage.Playing;
            SoundManager.ResumeAll();
        }
        public static void EventExit()
        {
            Main.gameStage = GameStage.Close;
        }
        public static void EventAccentColourChanged()
        {

        }
        public static void EventResolutionChanged()
        {
            MenuCategory resolutionMenu = ((MenuCategory)((MenuCategory)PauseMenu.MenuItems[1]).MenuItems[1]);
            string resolution = resolutionMenu.MenuItems[resolutionMenu.HoveredIndex].Text;
            string[] dimensions = resolution.Split('x');
            SetResolution(int.Parse(dimensions[0]), int.Parse(dimensions[1]));
        }
    }
}