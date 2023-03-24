using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Stella_Nova.Classes.Enums;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova
{
    public struct Star
    {
        public float size;
        public Vector2 pos;
        public Color colour;
    }
    public class Main : Game
    {
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static RenderTarget2D renderTarget;
        public static OpenSimplexNoise openSimplexNoise;
        public static Random random;
        public static Camera camera;
        
        public static MouseState currMouseState;
        public static MouseState prevMouseState;
        public static KeyboardState currKeyboardState;
        public static KeyboardState prevKeyboardState;
        public static GamePadState currGamePadState;
        public static GamePadState prevGamePadState;
        
        public static GameStage gameStage;

        public static Texture2D blur;
        public static Texture2D inverseBlur;
        public static Texture2D basic;
        public static Texture2D background;
        public static Texture2D vignette;
        public static Texture2D grunge;
        public static Texture2D cloud;
        public static Texture2D smoke;
        public static Texture2D circle;
        public static Texture2D ring;

        public static Effect Blur;
        public static Effect Bloom;
        public static Effect Invert;
        public static Effect Monochrome;
        public static Effect AlphaClamp;

        public static float GameSpeed;
        public static float NoiseOffset;
        public static int PhysicsDistance;
        public static int RenderDistance;
        public static bool isResetting;

        private static List<Star> stars;

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.IsBorderless = true;
        }
        protected override void Initialize()
        {
            random = new Random();
            openSimplexNoise = new OpenSimplexNoise();
            camera = new Camera();

            IsFixedTimeStep = false;
            graphics.SynchronizeWithVerticalRetrace = false;
            graphics.HardwareModeSwitch = false;
            graphics.IsFullScreen = true;

            Components.Add(new UIManager(this));
            Components.Add(new SoundManager(this));
            Components.Add(new AsteroidManager(this));
            Components.Add(new ProjectileManager(this));
            Components.Add(new ParticleManager(this));
            Components.Add(new PickupManager(this));
            Components.Add(new EntityManager(this));
            Components.Add(new PlayerManager(this));

            gameStage = GameStage.Menu;
            GameSpeed = 1f;
            NoiseOffset = 0f;
            PhysicsDistance = 2500;
            RenderDistance = 1000;
            
            stars = new List<Star>();

            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // Textures...
            blur = Drawing.Blur(24);
            basic = new Texture2D(spriteBatch.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            basic.SetData(new[] { Color.White });
            background = Content.Load<Texture2D>("Textures/Gradient");
            cloud = Drawing.Cloud(128, Color.White, new Vector3(120f, 128f, 0f), 0.04f);
            smoke = Drawing.Cloud(128, Color.White, new Vector3(120f, 128f, 0f), 0.004f);
            circle = Drawing.Circle(128, Color.White);
            ring = Drawing.SinBlur(128, Color.White);

            // Effects...
            Blur = Content.Load<Effect>("Shaders/Blur");
            Invert = Content.Load<Effect>("Shaders/Invert");
            Monochrome = Content.Load<Effect>("Shaders/Monochrome");
            AlphaClamp = Content.Load<Effect>("Shaders/AlphaClamp");

            for (int i = 0; i < 50; i++)
            {
                stars.Add(
                    new Star()
                    {
                        pos = new Vector2(
                            random.Next(0, graphics.PreferredBackBufferWidth),
                            random.Next(0, graphics.PreferredBackBufferHeight)),
                        size = 3f + (float)random.NextDouble() * 12f,
                        colour = Color.White
                    });
            }
        }
        protected override void Update(GameTime gameTime)
        {
            prevMouseState = currMouseState;
            currMouseState = Mouse.GetState();
            prevGamePadState = currGamePadState;
            currGamePadState = GamePad.GetState(0);
            prevKeyboardState = currKeyboardState;
            currKeyboardState = Keyboard.GetState();

            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            NoiseOffset += delta * GameSpeed;
            
            switch (gameStage)
            {
                case GameStage.Close:
                    {
                        Exit();
                        break;
                    }
                case GameStage.Menu:
                    {
                        if ((currGamePadState.Buttons.Start == ButtonState.Pressed && prevGamePadState.Buttons.Start == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Escape) && prevKeyboardState.IsKeyUp(Keys.Escape)))
                        {
                            UIManager.EventContinue();
                        }

                        // Select
                        if ((currGamePadState.Buttons.A == ButtonState.Pressed && prevGamePadState.Buttons.A == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Enter) && prevKeyboardState.IsKeyUp(Keys.Enter)) ||
                            (currKeyboardState.IsKeyDown(Keys.Right) && prevKeyboardState.IsKeyUp(Keys.Right)))
                            UIManager.PauseMenu.Navigate(Direction.Right);
                        // Deselect
                        if ((currGamePadState.Buttons.Back == ButtonState.Pressed && prevGamePadState.Buttons.Back == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Left) && prevKeyboardState.IsKeyUp(Keys.Left)))
                            UIManager.PauseMenu.Navigate(Direction.Left);
                        // Up
                        if ((currGamePadState.DPad.Up == ButtonState.Pressed && prevGamePadState.DPad.Up == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Up) && prevKeyboardState.IsKeyUp(Keys.Up)))
                            UIManager.PauseMenu.Navigate(Direction.Up);
                        // Down
                        if ((currGamePadState.DPad.Down == ButtonState.Pressed && prevGamePadState.DPad.Down == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Down) && prevKeyboardState.IsKeyUp(Keys.Down)))
                            UIManager.PauseMenu.Navigate(Direction.Down);

                        UIManager.menuCinematicLastChanged += delta;
                        if (UIManager.menuCinematicLastChanged >= UIManager.menuCinematicChangeTime)
                        {

                            UIManager.menuCinematicFadeTime += delta;
                            if (UIManager.menuCinematicFadeTime >= 1f)
                            {
                                if (!UIManager.menuCinematicHasChanged && AsteroidManager.asteroids.Count > 0)
                                {
                                    UIManager.menuCinematicTarget = AsteroidManager.asteroids[random.Next(AsteroidManager.asteroids.Count)];
                                    camera.Position = UIManager.menuCinematicTarget.Position;
                                    UIManager.menuCinematicHasChanged = true;
                                }

                                if (UIManager.menuCinematicFadeTime >= 2f)
                                {
                                    UIManager.menuCinematicLastChanged = 0f;
                                    UIManager.menuCinematicFadeTime = 0f;
                                    UIManager.menuCinematicHasChanged = false;
                                }
                            }
                        }

                        if (!(UIManager.menuCinematicTarget is null))
                            camera.Update(delta, 8f, UIManager.menuCinematicTarget.Position);

                        base.Update(gameTime);
                        break;
                    }
                case GameStage.Paused:
                    {
                        if ((currGamePadState.Buttons.Start == ButtonState.Pressed && prevGamePadState.Buttons.Start == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Escape) && prevKeyboardState.IsKeyUp(Keys.Escape)))
                        {
                            UIManager.EventContinue();
                        }

                        // Select
                        if ((currGamePadState.Buttons.A == ButtonState.Pressed && prevGamePadState.Buttons.A == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Enter) && prevKeyboardState.IsKeyUp(Keys.Enter)) ||
                            (currKeyboardState.IsKeyDown(Keys.Right) && prevKeyboardState.IsKeyUp(Keys.Right)))
                            UIManager.PauseMenu.Navigate(Direction.Right);
                        // Deselect
                        if ((currGamePadState.Buttons.Back == ButtonState.Pressed && prevGamePadState.Buttons.Back == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Left) && prevKeyboardState.IsKeyUp(Keys.Left)))
                            UIManager.PauseMenu.Navigate(Direction.Left);
                        // Up
                        if ((currGamePadState.DPad.Up == ButtonState.Pressed && prevGamePadState.DPad.Up == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Up) && prevKeyboardState.IsKeyUp(Keys.Up)))
                            UIManager.PauseMenu.Navigate(Direction.Up);
                        // Down
                        if ((currGamePadState.DPad.Down == ButtonState.Pressed && prevGamePadState.DPad.Down == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Down) && prevKeyboardState.IsKeyUp(Keys.Down)))
                            UIManager.PauseMenu.Navigate(Direction.Down);

                        break;
                    }
                case GameStage.Playing:
                    {
                        if (currKeyboardState.IsKeyDown(Keys.OemMinus))
                            camera.Scale -= delta;
                        if (currKeyboardState.IsKeyDown(Keys.OemPlus))
                            camera.Scale += delta;
                        if (currKeyboardState.IsKeyDown(Keys.OemCloseBrackets))
                        {
                            GameSpeed -= delta;
                            if (GameSpeed < 0)
                                GameSpeed = 0;
                        }
                        if (currKeyboardState.IsKeyDown(Keys.OemOpenBrackets))
                            GameSpeed += delta;

                        camera.Update(delta * GameSpeed, 8f, PlayerManager.player.Position);

                        if ((currGamePadState.Buttons.Start == ButtonState.Pressed && prevGamePadState.Buttons.Start == ButtonState.Released) ||
                            (currKeyboardState.IsKeyDown(Keys.Escape) && prevKeyboardState.IsKeyUp(Keys.Escape)))
                        {
                            gameStage = GameStage.Paused;
                            SoundManager.PauseAll();
                        }

                        if (UIManager.ScoreScale > 0.75f)
                        {
                            UIManager.ScoreScale -= delta * GameSpeed;
                            if (UIManager.ScoreScale < 0.75f)
                                UIManager.ScoreScale = 0.75f;
                        }

                        if (camera.Position.Length() > 1000000)
                            ResetToOrigin();

                        base.Update(gameTime);

                        break;
                    }
            }
        }
        protected override void Draw(GameTime gameTime)
        {
            // Clear the screen...
            GraphicsDevice.Clear(Color.Black);

            // Set the rendertarget to the virtual resolution rendertarget...
            graphics.GraphicsDevice.SetRenderTarget(renderTarget);
            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);

            // Draw the background...
            spriteBatch.Draw(background, new Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White * 0.5f);

            // Draw the stars...
            foreach (Star star in stars)
                spriteBatch.Draw(blur,
                    new Rectangle(
                        (int)star.pos.X, (int)star.pos.Y,
                        (int)star.size, (int)star.size),
                    star.colour * (float)openSimplexNoise.Evaluate(star.pos.X, star.pos.Y, NoiseOffset / 3f) * 2f);

            spriteBatch.End();

            // Draw all the remaining game components...
            base.Draw(gameTime);

            // Set the rendertarget back to the backbuffer...
            graphics.GraphicsDevice.SetRenderTarget(null);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Additive);
            
            // Apply all filters to the spritebatch...
            Monochrome.CurrentTechnique.Passes[0].Apply();

            // Render the final view to the screen...            
            if (graphics.IsFullScreen)
            {
                float stretchedX = graphics.PreferredBackBufferHeight * camera.AspectRatio;
                float stretchedY = graphics.PreferredBackBufferHeight;

                int diffX = (int)(UIManager.displayModes[UIManager.displayModes.Count - 1].Width - stretchedX);
                int diffY = (int)(UIManager.displayModes[UIManager.displayModes.Count - 1].Height - stretchedY);

                spriteBatch.Draw(
                    renderTarget,
                    new Rectangle(
                        diffX / 2, -diffY,
                        (int)stretchedX,
                        (int)stretchedY),
                    Color.White);
            }
            else
            {
                spriteBatch.Draw(
                    renderTarget,
                    new Rectangle(
                        0, 0,
                        UIManager.displayModes[UIManager.selectedDisplayMode].Width,
                        UIManager.displayModes[UIManager.selectedDisplayMode].Height),
                    Color.White);
            }

            spriteBatch.End();

            switch (gameStage)
            {
                case GameStage.Menu:
                    {
                        spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);

                        if (UIManager.menuCinematicLastChanged >= UIManager.menuCinematicChangeTime)
                            spriteBatch.Draw(basic,
                                new Rectangle(
                                    0, 0,
                                    graphics.PreferredBackBufferWidth,
                                    graphics.PreferredBackBufferHeight),
                                Color.Black * ((1f - Math.Abs(1f - UIManager.menuCinematicFadeTime)) / 1f));

                        Vector2 menuStringSize = UIManager.Roboto_Medium.MeasureString("STELLA NOVA") * UIManager.ScoreScale;
                        spriteBatch.DrawString(
                            UIManager.Roboto_Medium, "STELLA NOVA",
                                new Vector2(
                                    (graphics.GraphicsDevice.Viewport.Width / 24f),
                                    (graphics.GraphicsDevice.Viewport.Height / 12f - menuStringSize.Y / 2f)),
                                Color.FromNonPremultiplied(250, 169, 0, 256));

                        UIManager.PauseMenu.Draw(spriteBatch, true, true, new Vector2(100, graphics.PreferredBackBufferHeight / 2f));
                        
                        spriteBatch.End();
                        break;
                    }
                case GameStage.Paused:
                    {
                        spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);

                        if (PlayerManager.player.Weapons.Count > 0)
                            PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].DrawUI(spriteBatch);

                        Vector2 scoreStringSize = UIManager.Roboto_Medium.MeasureString($"{PlayerManager.player.Score}") * UIManager.ScoreScale;
                        spriteBatch.DrawString(
                            UIManager.Roboto_Medium, $"{PlayerManager.player.Score}",
                            new Vector2(
                                (graphics.GraphicsDevice.Viewport.Width / 2f) - (scoreStringSize.X / 2f),
                                (graphics.GraphicsDevice.Viewport.Height / 16f) - (scoreStringSize.Y / 2f)),
                            Color.Lerp(
                                Color.White, UIManager.ScoreHighlight, Utility.Map(UIManager.ScoreScale, 0.75f, 1f, 0f, 1f) * camera.Scale),
                                0f, Vector2.Zero, UIManager.ScoreScale * camera.Scale, SpriteEffects.None, 0);


                        UIManager.PauseMenu.Draw(spriteBatch, true, true, new Vector2(100, graphics.PreferredBackBufferHeight / 2f));

                        spriteBatch.End();
                        break;
                    }
                case GameStage.Playing:
                    {
                        spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);
                        
                        if (PlayerManager.player.Weapons.Count > 0)
                            PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].DrawUI(spriteBatch);

                        Vector2 scoreStringSize = UIManager.Roboto_Medium.MeasureString($"{PlayerManager.player.Score}") * UIManager.ScoreScale;
                        spriteBatch.DrawString(
                            UIManager.Roboto_Medium, $"{PlayerManager.player.Score}",
                            new Vector2(
                                (graphics.GraphicsDevice.Viewport.Width / 2f) - (scoreStringSize.X / 2f),
                                (graphics.GraphicsDevice.Viewport.Height / 16f) - (scoreStringSize.Y / 2f)),
                            Color.Lerp(
                                Color.White, UIManager.ScoreHighlight, Utility.Map(UIManager.ScoreScale, 0.75f, 1f, 0f, 1f) * camera.Scale),
                                0f, Vector2.Zero, UIManager.ScoreScale * camera.Scale, SpriteEffects.None, 0);
                        
                        spriteBatch.End();
                        break;
                    }
            }
        }
        public void ResetToOrigin()
        {
            isResetting = true;

            foreach (SpaceObject spaceObject in 
                (AsteroidManager.asteroids)
                .Concat<SpaceObject>(EntityManager.entities)
                .Concat(ParticleManager.particles)
                .Concat(PickupManager.pickups)
                .Concat(ProjectileManager.projectiles))
            {
                spaceObject.Position -= camera.Position;
            }

            PlayerManager.player.Position -= camera.Position;
            isResetting = false;
        }
    }
}