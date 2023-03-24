using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Grenade : HomingProjectile
    {
        public Grenade()
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y) : base(x, y)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }
        public Grenade(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {
            Light = new Vector2(0, 0);
            TrackingStrength = 10f;
        }

        protected Vector2 Light;

        public override List<Vector2> GenerateShape()
        {
            return new List<Vector2>()
            {                
                new Vector2( 16f, -4f),

                new Vector2(  4f, -8f),
                new Vector2(  4f,  8f),
                new Vector2(  4f, -8f),

                new Vector2(  2f, -6f),
                new Vector2( -2f, -6f),

                new Vector2( -4f, -8f),
                new Vector2( -4f,  8f),
                new Vector2( -4f, -8f),

                new Vector2(-16f, -4f),
                new Vector2(-16f,  4f),
                new Vector2( -4f,  8f),
                new Vector2( -2f,  6f),
                new Vector2(  2f,  6f),
                new Vector2(  4f,  8f),
                new Vector2( 16f,  4f),
            };
        }
        public override void FindCollisions()
        {
            List<Entity> entities = AsteroidManager.FindAll(Polygon.Rectangle).Cast<Entity>()
                .Concat(EntityManager.FindAll(Polygon.Rectangle)).ToList();

            if (TeamIndex != PlayerManager.player.TeamIndex && PlayerManager.player.Polygon.Rectangle.Intersects(Polygon.Rectangle))
                entities.Add(PlayerManager.player);

            if (entities.Count > 0)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    if (entities[i].TeamIndex == TeamIndex)
                        continue;

                    Destroy();
                    return;
                }
            }
        }
        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(
                new Explosion(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 0f, 256, Color.Azure, Color.DodgerBlue, Color.MidnightBlue, Color.PowderBlue));
            
            // ProjectileManager.projectiles.Add(
            //    new Implosion(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, 9999, 2560, 3000, 0.3f, 1.9f, 0.5f, 600, 0f, 1400f, 4000f));

            base.Destroy();
        }
        public override void Update(float delta)
        {
            if (!(Target is null))
            {
                float distance = Vector2.Distance(Position, Target.Position) / TrackingRange;
                Acceleration += (Target.Position - Position) * TrackingStrength * (1 / (distance * distance));
            }

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Vector2 lightRotated = Utility.RotateVector(Light, Angle);

            float lightStrength;
            if (TimeAlive % 0.5f < 0.3f)
                lightStrength = 2f;
            else lightStrength = 0.3f;

            spriteBatch.Draw(Main.blur,
                new Rectangle(
                    (int)(Position.X + lightRotated.X - 4),
                    (int)(Position.Y + lightRotated.Y - 4),
                    8, 8), Color.DarkRed * lightStrength);
            Drawing.DrawLine(spriteBatch, Position + lightRotated - Vector2.One, Position + lightRotated + Vector2.One, Color.FromNonPremultiplied(232, 156, 1, 256) * lightStrength, 3f);

            Polygon.Draw(spriteBatch, Color.White, 2f);
        }
    }
}