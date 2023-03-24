using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;

namespace Stella_Nova.Classes.Objects.Missions
{
    public abstract class Mission
    {
        public Mission()
        {
            Title = "?";
            Description = "?";
            Reward = 100;
        }
        public Mission(string title)
        {
            Title = title;
            Description = "?";
            Reward = 100;
        }
        public Mission(string title, string description)
        {
            Title = title;
            Description = description;
            Reward = 100;
        }
        public Mission(string title, string description, int reward)
        {
            Title = title;
            Description = description;
            Reward = reward;
        }

        public string Title;
        public string Description;

        public MissionState State;
        public int Reward;

        public abstract void Update(float delta);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}