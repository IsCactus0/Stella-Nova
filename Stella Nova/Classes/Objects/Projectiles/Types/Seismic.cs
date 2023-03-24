using Stella_Nova.Classes.Managers;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Seismic : Grenade
    {
        public Seismic()
        {

        }
        public Seismic(float x, float y)
            : base(x, y)
        {

        }
        public Seismic(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex) 
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {

        }
        public Seismic(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {

        }

        public override void Destroy()
        {
            ProjectileManager.projectiles.Add(
                new Explosion(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 0f, 256));

            ProjectileManager.projectiles.Add(
                new Implosion(Position.X, Position.Y, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, TeamIndex, 9999, 256, 300, 0.3f, 1.9f, 10f, 256, 20f, 40000f, 40000f));

            base.Destroy();
        }
        public override void Update(float delta)
        {
            base.Update(delta);
        }
    }
}