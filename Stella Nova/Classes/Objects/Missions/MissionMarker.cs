using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using System;

namespace Stella_Nova.Classes.Objects.Missions
{
    public class MissionMarker
    {
        public MissionMarker(Vector2 position)
        {
            Position = position;
        }

        public Vector2 Position;

        public void Draw(SpriteBatch spriteBatch)
        {
            float buffer = Main.graphics.PreferredBackBufferWidth / 60f;
            spriteBatch.DrawString(
                UIManager.Roboto_Regular, "V",
                new Vector2(
                    Math.Clamp(
                        (Main.camera.Position.X + Main.graphics.PreferredBackBufferWidth / 2f) - Position.X,
                        buffer, Main.graphics.PreferredBackBufferWidth - buffer),
                    Math.Clamp(
                        (Main.camera.Position.Y + Main.graphics.PreferredBackBufferHeight / 2f) - Position.Y,
                        buffer, Main.graphics.PreferredBackBufferHeight - buffer)), Color.FromNonPremultiplied(220, 40, 40, 200));
        }
    }
}
