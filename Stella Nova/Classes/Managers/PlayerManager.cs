using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.Effects;
using Stella_Nova.Classes.Objects.Weapons.Types;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Managers
{
    public class PlayerManager : DrawableGameComponent
    {
        public static SpriteBatch spriteBatch;
        public static Dictionary<string, Buttons> GamePadMap;
        public static Dictionary<string, Keys> KeyboardMap;

        public static Player player;

        public PlayerManager(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
        }
        public override void Initialize()
        {
            KeyboardMap = new Dictionary<string, Keys>()
            {
                { "thrust", Keys.W },
                { "turn_left", Keys.A },
                { "reverse", Keys.S },
                { "turn_right", Keys.D },
                { "weapon_fire", Keys.Space },
                { "weapon_reload", Keys.R },
                { "weapon_wheel_left", Keys.Q },
                { "weapon_wheel_right", Keys.E },
                { "warp_jump", Keys.T },
                { "activate_selected_ability", Keys.O },
                { "deactivate_selected_ability", Keys.P },
            };
            GamePadMap = new Dictionary<string, Buttons>()
            {
                { "thrust", Buttons.RightTrigger },
                { "turn_left", Buttons.LeftThumbstickLeft },
                { "reverse", Buttons.LeftTrigger },
                { "turn_right", Buttons.LeftThumbstickRight },
                { "weapon_fire", Buttons.A },
                { "weapon_reload", Buttons.X },
                { "weapon_wheel_left", Buttons.LeftShoulder },
                { "weapon_wheel_right", Buttons.RightShoulder },
                { "warp_jump", Buttons.DPadUp },
            };

            player = new Player(
                Main.graphics.PreferredBackBufferWidth / 2,
                Main.graphics.PreferredBackBufferHeight / 2,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 10f, 0.4f);

            player.Weapons.Add(new LaserRifle());
            player.Weapons.Add(new PlasmaRifle());
            player.Weapons.Add(new HomingMissile());
            player.Statuses.Add(new Shield());

            base.Initialize();
        }
        public override void Update(GameTime gameTime)
        {
            if (Main.GameSpeed <= 0)
                return;
            if (player is null)
                return;
            
            float delta = ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * Main.GameSpeed;
            player.Update(delta);

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            if (player is null)
                return;

            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            float velocity = player.Velocity.Length();
            Vector2 sizeVel = UIManager.Roboto_Medium.MeasureString(velocity.ToString("0.00")) * 0.4f;
            Vector2 sizeGauge = UIManager.Roboto_LightItalic.MeasureString("m/s") * 0.25f;

            spriteBatch.DrawString(UIManager.Roboto_Medium, velocity.ToString("0.00"),
                new Vector2(400f - sizeVel.X, 0f), Color.White, 0f, Vector2.Zero, 0.4f, SpriteEffects.None, 0f);

            spriteBatch.DrawString(UIManager.Roboto_LightItalic, "m/s",
                 new Vector2(410f, sizeVel.Y - sizeGauge.Y), Color.White, 0f, Vector2.Zero, 0.25f, SpriteEffects.None, 0f);

            spriteBatch.Draw(Main.basic, new Rectangle(10, 10, (int)Math.Clamp(velocity, 0f, 220f), 10), Color.White);
            spriteBatch.End();

            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive, null, null, null, null, transformMatrix: Main.camera.Transform);
            player.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}