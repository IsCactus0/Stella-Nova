using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Enemies.Types;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Utilities;
using System;

namespace Stella_Nova.Classes.Objects.Missions
{
    public class EscortMission : Mission
    {
        public EscortMission()
            : base()
        {
        }
        public EscortMission(string title)
            : base(title)
        {
        }
        public EscortMission(string title, string description)
            : base(title, description)
        {
        }
        public EscortMission(string title, string description, int reward)
            : base(title, description, reward)
        {
        }
        public EscortMission(string title, string description, int reward, Entity target)
            : base(title, description, reward)
        {
            Target = target;
            MissionMarker = new MissionMarker(Target.Position);
        }
        public EscortMission(string title, string description, int reward, Entity target, Vector2 safety)
            : base(title, description, reward)
        {
            Target = target;
            Safety = safety;
            MissionMarker = new MissionMarker(Target.Position);
        }
        public EscortMission(string title, string description, int reward, Entity target, Vector2 safety, float maxRange)
            : base(title, description, reward)
        {
            Target = target;
            Safety = safety;
            MaxRange = maxRange;
            MissionMarker = new MissionMarker(Target.Position);
        }

        public Entity Target;
        public Vector2 Safety;
        public float MaxRange;

        public MissionMarker MissionMarker;
        public float WarningCountdown;

        public override void Update(float delta)
        {
            MissionMarker.Position = Target.Position;

            if (Vector2.Distance(Target.Position, PlayerManager.player.Position) > MaxRange)
                WarningCountdown += delta;
            else WarningCountdown = 0;

            if (Target.Health <= 0 || WarningCountdown > 10f) Fail();
            if (Vector2.Distance(Target.Position, Safety) < 100) Pass();

            if (Utility.CalculateChancePerSecond(delta, 0.001f))
            {
                Vector2 position = Utility.RandomAlongBorder(Main.graphics.GraphicsDevice.Viewport.Bounds, 300f, 0);
                EntityManager.entities.Add(new Drone(position.X, position.Y));
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            MissionMarker.Draw(spriteBatch);

            Vector2 titleSize = UIManager.Roboto_Regular.MeasureString(Title) * 0.3f;
            spriteBatch.DrawString(
                UIManager.Roboto_Regular, Title,
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth / 50f,
                    Main.graphics.PreferredBackBufferWidth / 50f),
                Color.FromNonPremultiplied(220, 40, 40, 255), 0f, Vector2.Zero, 0.3f * Main.camera.Scale, SpriteEffects.None, 0);

            float distance = Vector2.Distance(PlayerManager.player.Position, Target.Position) / 10f;
            string distanceString = $"{distance.ToString("#")}m";
            Vector2 distanceSize = UIManager.Roboto_Regular.MeasureString(distanceString) * 0.2f;
            spriteBatch.DrawString(
                UIManager.Roboto_Regular, distanceString,
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth / 48f,
                    Main.graphics.PreferredBackBufferWidth / 50f + titleSize.Y * 1.25f),
                Color.FromNonPremultiplied(220, 40, 40, 255), 0f, Vector2.Zero, 0.15f * Main.camera.Scale, SpriteEffects.None, 0);

            spriteBatch.DrawString(
                UIManager.Roboto_LightItalic, "| " + Description,
                new Vector2(
                    Main.graphics.PreferredBackBufferWidth / 48f + distanceSize.X * 1.1f,
                    Main.graphics.PreferredBackBufferWidth / 50f + titleSize.Y * 1.25f),
                Color.White, 0f, Vector2.Zero, 0.15f * Main.camera.Scale, SpriteEffects.None, 0);


        }
        public void Fail()
        {
            State = Enums.MissionState.Failed;
            Target.Destroy();
        }
        public void Pass()
        {
            State = Enums.MissionState.Completed;
            PlayerManager.player.Score += Reward;
            Console.WriteLine("Pass");
        }
    }
}