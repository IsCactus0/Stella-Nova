using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public class Projectile : SpaceObject
    {
        public Projectile()
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Mass = 20f;
            Polygon = new Polygon(Vector3.Zero, GenerateShape());            
        }
        public Projectile(Projectile projectile)
        {
            TeamIndex = projectile.TeamIndex;
            Penetration = projectile.Penetration;
            MinDamage = projectile.MinDamage;
            MaxDamage = projectile.MaxDamage;
            CritChance = projectile.CritChance;
            CritBonus = projectile.CritBonus;
            MaxLifespan = projectile.MaxLifespan;
            Polygon = projectile.Polygon.Copy();
        }
        public Projectile(float x, float y)
            : base(x, y)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Mass = 20f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Mass = 20f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Mass = 20f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Mass = 20f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Mass = 20f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Mass = 20f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = -1;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = playerIndex;
            Penetration = 1;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = playerIndex;
            Penetration = penetration;
            MinDamage = 12;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());            
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = playerIndex;
            Penetration = penetration;
            MinDamage = minDamage;
            MaxDamage = 48;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = playerIndex;
            Penetration = penetration;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CritChance = 0.1f;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = playerIndex;
            Penetration = penetration;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CritChance = critChance;
            CritBonus = 0.5f;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = playerIndex;
            Penetration = penetration;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CritChance = critChance;
            CritBonus = critBonus;
            MaxLifespan = 5f;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }
        public Projectile(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {
            TeamIndex = playerIndex;
            Penetration = penetration;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CritChance = critChance;
            CritBonus = critBonus;
            MaxLifespan = maxLifespan;
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public int TeamIndex;
        public int Penetration;
        public int MinDamage;
        public int MaxDamage;
        public float CritChance;
        public float CritBonus;
        public float MaxLifespan;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(12, 12);
        }
        public override void FindCollisions()
        {
            List<Entity> entities = AsteroidManager.FindAll(this.Polygon.Rectangle)
                            .Concat(EntityManager.FindAll(this.Polygon.Rectangle)).ToList();
            if (TeamIndex != 1 && PlayerManager.player.Polygon.Rectangle.Intersects(this.Polygon.Rectangle))
                entities.Add(PlayerManager.player);

            if (entities.Count > 0)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    if (entities[i].TeamIndex == TeamIndex || TimeAlive <= 0.05f)
                        continue;
                    
                    Penetration--;
                    TimeAlive = 0;

                    if (Penetration <= 0)
                        Destroy();

                    float damage = Main.random.Next(MinDamage, MaxDamage + 1);
                    bool isCrit = (float)Main.random.NextDouble() <= CritChance;
                    int finalDamage = (int)Math.Round(damage * (isCrit ? CritBonus : 1), 0);

                    entities[i].Damage(finalDamage, MinDamage, MaxDamage, CritBonus, isCrit, TeamIndex, Position);
                }
            }
        }
        public override void Destroy()
        {
            // Move object outside physics range as to avoid object updates...
            this.Position.X -= Main.PhysicsDistance * 2f;
            ProjectileManager.projectiles.Remove(this);
        }
        public override void Update(float delta)
        {
            if (TimeAlive >= MaxLifespan || Penetration <= 0)
                Destroy();

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Polygon.Draw(spriteBatch, Color.White);
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}