using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public class CopperWarhead : Projectile
    {
        public CopperWarhead()
        {

        }
        public CopperWarhead(Projectile projectile) 
            : base(projectile)
        {

        }
        public CopperWarhead(float x, float y)
            : base(x, y)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay) 
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle) 
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {

        }
        public CopperWarhead(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {

        }

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Asteroid(12, 2, 10f, 24, Position / 500f, Main.openSimplexNoise, Main.random);
        }
        public override void Update(float delta)
        {
            if (Utility.CalculateChancePerSecond(delta, 5f * (1f - TimeAlive / MaxLifespan)))
            {
                for (int i = 0; i < 3; i++)
                {
                    ParticleManager.particles.Add(
                        new Spark(
                            Polygon.Origin.X + ((float)Main.random.NextDouble() - 0.5f) * 6f,
                            Polygon.Origin.Y + ((float)Main.random.NextDouble() - 0.5f) * 6f,
                            0f, 0f, 0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 0.1f,
                            0.1f + (float)Main.random.NextDouble() / 5f, TeamIndex, 16,
                            Color.Chocolate * 1.2f, Color.White, Color.SaddleBrown));

                    ParticleManager.particles.Add(
                        new Smoke(
                            Polygon.Origin.X,
                            Polygon.Origin.Y,
                            0f, 0f, 0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 3f, 0.1f,
                            0.4f + (float)Main.random.NextDouble() / 2f, TeamIndex, 24,
                            Color.Coral * 0.4f, Color.Black * 0.4f));
                }
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 12, (int)Position.Y - 12, 24, 24), Color.Chocolate * 1.2f);
            spriteBatch.Draw(Main.blur, new Rectangle((int)Position.X - 6, (int)Position.Y - 6, 12, 12), Color.White);
        }
    }
}