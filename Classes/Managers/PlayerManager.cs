using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Objects;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Managers
{
    public class PlayerManager : DrawableGameComponent
    {
        public static SpriteBatch spriteBatch;
        public static Player player;
        public static List<Color> colours;

        public PlayerManager(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            colours = new List<Color>()
            {
                Color.Crimson,
                Color.MintCream,
                Color.Goldenrod,
                Color.DodgerBlue,
                Color.Coral,
                Color.SlateBlue,
                Color.DarkMagenta,
                Color.HotPink,
                Color.CornflowerBlue,
                Color.GreenYellow,
                Color.Lime,
                Color.DarkOliveGreen
            };
        }
        public override void Update(GameTime gameTime)
        {
            if (Main.isResetting || Main.GameSpeed <= 0)
                return;

            float delta = ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * Main.GameSpeed;
            player.Update(delta);

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);
            player.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}