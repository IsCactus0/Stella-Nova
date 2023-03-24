using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Projectiles
{
    public abstract class Projectile : SpaceObject
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
            Polygon = new Polygon(Vector3.Zero, GenerateShape());            
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
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
            ImpactSounds = new List<SoundEffect>();
            BreakSounds = new List<SoundEffect>();
            AmbientSounds = new List<SoundEffect>();
            Polygon = new Polygon(new Vector3(x, y, 0), GenerateShape());
        }

        public int TeamIndex;
        public int Penetration;
        public int MinDamage;
        public int MaxDamage;
        public float CritChance;
        public float CritBonus;
        public float MaxLifespan;

        public List<SoundEffect> ImpactSounds;
        public List<SoundEffect> BreakSounds;
        public List<SoundEffect> AmbientSounds;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(16, 6);
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
                    
                    Penetration--;
                    TimeAlive = 0;

                    float damage = Main.random.Next(MinDamage, MaxDamage + 1);
                    bool isCrit = (float)Main.random.NextDouble() <= CritChance;
                    int finalDamage = (int)Math.Round(damage * (isCrit ? CritBonus : 1), 0);

                    entities[i].Damage(finalDamage, MinDamage, MaxDamage, CritBonus, isCrit, TeamIndex, Position);

                    if (ImpactSounds.Count > 0)
                        SoundManager.PlaySound3D(ImpactSounds[Main.random.Next(ImpactSounds.Count)], Position, Velocity);

                    if (Penetration <= 0)
                        Destroy();
                }
            }
        }
        public override void Destroy()
        {
            // Move object outside physics range as to avoid object updates...
            Position.X -= Main.PhysicsDistance * 2f;
            ProjectileManager.projectiles.Remove(this);

            if (BreakSounds.Count > 0)
                SoundManager.PlaySound3D(BreakSounds[Main.random.Next(BreakSounds.Count)], Position, Velocity);
        }
        public override void Update(float delta)
        {
            base.Update(delta);

            if (TimeAlive >= MaxLifespan || Penetration <= 0)
                Destroy();
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