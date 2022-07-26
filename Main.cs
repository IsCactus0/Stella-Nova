using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects;
using Stella_Nova.Classes.Objects.Abilities;
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
        public static Random random;
        public static OpenSimplexNoise openSimplexNoise;
        public static List<DisplayMode> displayModes;
        public static int selectedDisplayMode;
        public static Camera camera;

        // Managers...
        AsteroidManager asteroidManager;
        ProjectileManager projectileManager;
        ParticleManager particleManager;
        PickupManager pickupManager;
        PlayerManager playerManager;
        EntityManager entityManager;

        // User Inputs...
        public static MouseState currMouseState;
        public static MouseState prevMouseState;
        public static KeyboardState currKeyboardState;
        public static KeyboardState prevKeyboardState;
        public static GamePadState currGamePadState;
        public static GamePadState prevGamePadState;

        // Textures...
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

        // Fonts...
        public static SpriteFont Roboto_Medium;
        public static SpriteFont Roboto_Light;
        public static SpriteFont Roboto_LightItalic;

        // Universal Variables...
        // Gameplay...
        public static float GameSpeed;
        public static float NoiseOffset;
        public static int PhysicsDistance;
        public static int RenderDistance;
        public static bool isResetting;
        public static int PointsToNextUpgrade;
        public static float ScoreScale;
        public static Color ScoreHighlight;
        public static int MinQuadTreeResolution;
        // Ambience
        public static List<Star> stars;
        public static float sunAngle = MathHelper.PiOver4;
        public static Color sunColour;
        public static Color ambientColour;

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            random = new Random();
            openSimplexNoise = new OpenSimplexNoise();
            displayModes = new List<DisplayMode>();
            stars = new List<Star>();

            foreach (DisplayMode displayMode in GraphicsAdapter.DefaultAdapter.SupportedDisplayModes)
                displayModes.Add(displayMode);

            selectedDisplayMode = displayModes.Count - 1;
            IsFixedTimeStep = false;
            graphics.IsFullScreen = true;
            graphics.SynchronizeWithVerticalRetrace = false;
            graphics.HardwareModeSwitch = false;
            graphics.PreferredBackBufferWidth = displayModes[selectedDisplayMode].Width;
            graphics.PreferredBackBufferHeight = displayModes[selectedDisplayMode].Height;
            graphics.ApplyChanges();

            Components.Add(asteroidManager = new AsteroidManager(this));
            Components.Add(projectileManager = new ProjectileManager(this));
            Components.Add(particleManager = new ParticleManager(this));
            Components.Add(pickupManager = new PickupManager(this));
            Components.Add(playerManager = new PlayerManager(this));
            Components.Add(entityManager = new EntityManager(this));

            GameSpeed = 1f;
            NoiseOffset = 0f;
            PhysicsDistance = 2500;
            RenderDistance = 1000;
            ScoreScale = 0.75f;

            camera = new Camera(new Viewport(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 2, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight));
            camera.Zoom = 0.8f;

            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // Textures...
            blur = Drawing.Blur(24);
            basic = new Texture2D(spriteBatch.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            basic.SetData(new[] { Color.White });
            background = Content.Load<Texture2D>("Gradient");
            cloud = Drawing.Cloud(128, Color.White, new Vector3(120f, 128f, 0f), 0.04f);
            smoke = Drawing.Cloud(128, Color.White, new Vector3(120f, 128f, 0f), 0.004f);
            circle = Drawing.Circle(128, Color.White);
            ring = Drawing.SinBlur(128, Color.White);

            // Fonts...
            Roboto_Medium = Content.Load<SpriteFont>("Fonts/Roboto-Medium");
            Roboto_Light = Content.Load<SpriteFont>("Fonts/Roboto-Light");
            Roboto_LightItalic = Content.Load<SpriteFont>("Fonts/Roboto-LightItalic");

            // Spawn new player...
            PlayerManager.player = new Player(
                    Window.ClientBounds.Width / 2,
                    Window.ClientBounds.Height / 2,
                    0f, 0f, 0f, 0f, 0f, 0f, 0f, 10f, 0.4f);

            for (int i = 0; i < 500; i++)
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
            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            NoiseOffset += ((float)gameTime.ElapsedGameTime.Ticks / TimeSpan.TicksPerSecond) * GameSpeed;
            camera.Update(delta * GameSpeed, 8f, PlayerManager.player.Position);

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Control game speed for testing...
            if (Keyboard.GetState().IsKeyDown(Keys.OemComma))
                GameSpeed -= delta;
            if (Keyboard.GetState().IsKeyDown(Keys.OemPeriod))
                GameSpeed += delta;
            if (Keyboard.GetState().IsKeyDown(Keys.OemQuestion))
                GameSpeed = 1f;
            if (GameSpeed < 0)
                GameSpeed = 0;

            if (Keyboard.GetState().IsKeyDown(Keys.OemPlus))
                camera.Zoom += delta;
            if (Keyboard.GetState().IsKeyDown(Keys.OemMinus))
                camera.Zoom -= delta;
            if (Keyboard.GetState().IsKeyDown(Keys.OemCloseBrackets))
                camera.Zoom = 1f;

            if (Keyboard.GetState().IsKeyDown(Keys.NumPad6))
                camera.OffX += delta * 500f;
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad4))
                camera.OffX -= delta * 500f;
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad5))
                camera.OffY += delta * 500f;
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad8))
                camera.OffY -= delta * 500f;
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad7))
                camera.Offset = Vector2.Zero;

            if (ScoreScale > 0.75f)
            {
                ScoreScale -= delta * GameSpeed;
                if (ScoreScale < 0.75f)
                    ScoreScale = 0.75f;
            }

            if (camera.Position.Length() > 1000000)
                ResetToOrigin();

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.NonPremultiplied);
            spriteBatch.Draw(background, new Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White * 0.6f);
            spriteBatch.End();

            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            foreach (Star star in stars)
                spriteBatch.Draw(blur,
                    new Rectangle(
                        (int)star.pos.X, (int)star.pos.Y,
                        (int)star.size, (int)star.size),
                    star.colour * (float)openSimplexNoise.Evaluate(star.pos.X, star.pos.Y, NoiseOffset / 3f) * 2f);
            spriteBatch.End();

            base.Draw(gameTime);

            spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
            // Draw score...
            Vector2 scoreStringSize = Roboto_Medium.MeasureString($"{PlayerManager.player.Score}") * ScoreScale;
            spriteBatch.DrawString(
                Roboto_Medium, $"{PlayerManager.player.Score}",
                new Vector2((graphics.PreferredBackBufferWidth / 2f) - (scoreStringSize.X / 2f), 80 - scoreStringSize.Y / 2f),
                Color.Lerp(Color.PowderBlue, ScoreHighlight, Utility.Map(ScoreScale, 0.75f, 1f, 0f, 1f)), 0f, Vector2.Zero, ScoreScale, SpriteEffects.None, 0);

            // Draw healthbar...
            Drawing.DrawLine(spriteBatch,
                new Vector2(graphics.PreferredBackBufferWidth / 2f - PlayerManager.player.MaxHealth * 2.4f, graphics.PreferredBackBufferHeight - 60),
                new Vector2(graphics.PreferredBackBufferWidth / 2f + PlayerManager.player.MaxHealth * 2.4f, graphics.PreferredBackBufferHeight - 60),
                Color.PowderBlue * 0.75f, 16f);
            Drawing.DrawLine(spriteBatch,
                new Vector2(graphics.PreferredBackBufferWidth / 2f - PlayerManager.player.Health * 2.4f, graphics.PreferredBackBufferHeight - 60),
                new Vector2(graphics.PreferredBackBufferWidth / 2f + PlayerManager.player.Health * 2.4f, graphics.PreferredBackBufferHeight - 60),
                Color.PowderBlue * 0.75f, 16f);

            // Draw shieldbar...
            Drawing.DrawLine(spriteBatch,
                new Vector2(graphics.PreferredBackBufferWidth / 2f - PlayerManager.player.MaxShieldStrength * 2.4f, graphics.PreferredBackBufferHeight - 40),
                new Vector2(graphics.PreferredBackBufferWidth / 2f + PlayerManager.player.MaxShieldStrength * 2.4f, graphics.PreferredBackBufferHeight - 40),
                Color.PowderBlue * 0.75f, 16f);
            Drawing.DrawLine(spriteBatch,
                new Vector2(graphics.PreferredBackBufferWidth / 2f - PlayerManager.player.ShieldStrength * 2.4f, graphics.PreferredBackBufferHeight - 40),
                new Vector2(graphics.PreferredBackBufferWidth / 2f + PlayerManager.player.ShieldStrength * 2.4f, graphics.PreferredBackBufferHeight - 40),
                Color.PowderBlue * 0.75f, 16f);

            // Draw border...
            Drawing.DrawLine(spriteBatch,
                new Vector2(graphics.PreferredBackBufferWidth / 2f - PlayerManager.player.MaxHealth * 2.5f, graphics.PreferredBackBufferHeight - 68),
                new Vector2(graphics.PreferredBackBufferWidth / 2f - PlayerManager.player.MaxHealth * 2.5f, graphics.PreferredBackBufferHeight - 51),
                Color.PowderBlue * 1f, 5f);
            Drawing.DrawLine(spriteBatch,
                new Vector2(graphics.PreferredBackBufferWidth / 2f + PlayerManager.player.MaxHealth * 2.5f, graphics.PreferredBackBufferHeight - 68),
                new Vector2(graphics.PreferredBackBufferWidth / 2f + PlayerManager.player.MaxHealth * 2.5f, graphics.PreferredBackBufferHeight - 51),
                Color.PowderBlue * 1f, 5f);

            // Draw Acceleration...
            int speed = (int)(PlayerManager.player.Velocity.Length() / 9.8f);
            string text = $"{String.Format("{0:.00}", (speed / 800f))}c";
            Vector2 textSize = Roboto_Medium.MeasureString(text) * 0.3f;
            Vector2 centre = new Vector2(graphics.PreferredBackBufferWidth / 16f, graphics.PreferredBackBufferHeight - graphics.PreferredBackBufferWidth / 16f);
            
            spriteBatch.DrawString(
                Roboto_Light, text,
                new Vector2(centre.X - textSize.X / 2f, centre.Y - textSize.Y / 2f),
                Color.PowderBlue, 0f, Vector2.Zero, 0.3f, SpriteEffects.None, 0);
            
            int detail = 80;
            for (int i = 0; i < detail; i++)
            {
                float angle = MathHelper.TwoPi / detail * i;
                if (i < speed)
                Drawing.DrawLine(spriteBatch,
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 80,
                        centre.Y + (float)Math.Sin(angle) * 80),
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 100,
                        centre.Y + (float)Math.Sin(angle) * 100),
                    Color.Coral, 4f);
                else
                Drawing.DrawLine(spriteBatch,
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 80,
                        centre.Y + (float)Math.Sin(angle) * 80),
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 100,
                        centre.Y + (float)Math.Sin(angle) * 100),
                    Color.Coral * 0.4f, 2f);
            
                if (i % 10 == 0)
                    Drawing.DrawLine(spriteBatch,
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 50,
                        centre.Y + (float)Math.Sin(angle) * 50),
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 70,
                        centre.Y + (float)Math.Sin(angle) * 70),
                    Color.White * 0.5f, 5f);
            }

            // Draw all active abilities' UI
            foreach (Ability ability in PlayerManager.player.Abilities)
                if (ability.isActive)
                    ability.DrawUI(spriteBatch);


            // Draw ammunition...
            PlayerManager.player.Weapons[PlayerManager.player.SelectedWeapon].Draw(spriteBatch);
            spriteBatch.End();
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
            camera.Position = Vector2.Zero;
            isResetting = false;
        }
    }
}