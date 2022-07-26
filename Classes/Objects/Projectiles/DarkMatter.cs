using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Utilities;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public class DarkMatter : Projectile
    {
        public DarkMatter()
        {

        }
        public DarkMatter(Projectile projectile)
            : base(projectile)
        {

        }
        public DarkMatter(float x, float y)
            : base(x, y)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {

        }
        public DarkMatter(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {

        }

        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 15f * (1f - TimeAlive / MaxLifespan)))
            {
                ParticleManager.particles.Add(
                    new Spark(
                        Polygon.Origin.X + ((float)Main.random.NextDouble() - 0.5f) * 2f,
                        Polygon.Origin.Y + ((float)Main.random.NextDouble() - 0.5f) * 2f,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 0.1f, 0.05f + (float)Main.random.NextDouble() / 5f, TeamIndex, 12,
                        Color.Violet * 1.2f, Color.White, Color.MediumOrchid * 1.2f));

                ParticleManager.particles.Add(
                    new Smoke(
                        Polygon.Origin.X,
                        Polygon.Origin.Y,
                        0f, 0f, 0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 0.1f, 0.1f, 0.2f + (float)Main.random.NextDouble() / 2f, TeamIndex, 32,
                        Color.DarkSlateBlue * 0.4f, Color.Black * 0.4f));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 12, (int)Position.Y - 12, 24, 24), Color.Violet * 1.2f);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 6, (int)Position.Y - 6, 12, 12), Color.White);
        }
    }
}