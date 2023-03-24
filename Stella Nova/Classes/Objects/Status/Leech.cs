using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Effects
{
    public class Leech : Status
    {
        public Leech()
        {
            this.Range = 500f;
            this.MinDamage = 1;
            this.MaxDamage = 5;
            this.CritChance = 0.2f;
            this.CritBonus = 1.3f;
            this.isActive = true;
        }
        public Leech(float useTime)
            : base(useTime)
        {
            this.Range = 500f;
            this.MinDamage = 1;
            this.MaxDamage = 5;
            this.CritChance = 0.2f;
            this.CritBonus = 1.3f;
            this.isActive = true;
        }
        public Leech(float useTime, float range)
            : base(useTime)
        {
            this.Range = range;
            this.MinDamage = 1;
            this.MaxDamage = 5;
            this.CritChance = 0.2f;
            this.CritBonus = 1.3f;
            this.isActive = true;
        }
        public Leech(float useTime, float range, int minDamage)
            : base(useTime)
        {
            this.Range = range;
            this.MinDamage = minDamage;
            this.MaxDamage = 5;
            this.CritChance = 0.2f;
            this.CritBonus = 1.3f;
            this.isActive = true;
        }
        public Leech(float useTime, float range, int minDamage, int maxDamage)
            : base(useTime)
        {
            this.Range = range;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.CritChance = 0.2f;
            this.CritBonus = 1.3f;
            this.isActive = true;
        }
        public Leech(float useTime, float range, int minDamage, int maxDamage, float critChance)
            : base(useTime)
        {
            this.Range = range;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.CritChance = critChance;
            this.CritBonus = 1.3f;
            this.isActive = true;
        }
        public Leech(float useTime, float range, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(useTime)
        {
            this.Range = range;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.CritChance = critChance;
            this.CritBonus = critBonus;
            this.isActive = true;
        }
        public Leech(float useTime, float range, int minDamage, int maxDamage, float critChance, float critBonus, bool isActive)
            : base(useTime)
        {
            this.Range = range;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.CritChance = critChance;
            this.CritBonus = critBonus;
            this.isActive = isActive;
        }

        public float Range;
        public int MinDamage;
        public int MaxDamage;
        public float CritChance;
        public float CritBonus;

        public override void Update(float delta, Entity origin)
        {
            base.Update(delta, origin);

            LastUsed += delta;
            if (LastUsed < UseTime)
                return;

            LastUsed = 0f;
            List<Entity> entities = AsteroidManager.FindAll(origin.Position, Range)
                            .Concat(EntityManager.FindAll(origin.Position, Range)).Cast<Entity>().ToList();

            if (entities.Count > 0)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    if (entities[i].TeamIndex == origin.TeamIndex)
                        continue;

                    float damage = Main.random.Next(MinDamage, MaxDamage + 1);
                    bool isCrit = (float)Main.random.NextDouble() <= CritChance;
                    int finalDamage = (int)Math.Round(damage * (isCrit ? CritBonus : 1), 0);

                    origin.Heal(finalDamage, MinDamage, MaxDamage, CritBonus, isCrit);
                    entities[i].Damage(finalDamage, MinDamage, MaxDamage, CritBonus, isCrit, origin.TeamIndex, entities[i].Position);

                    for (int j = 0; j < Main.random.Next(finalDamage * 10); j++)
                    {
                        ParticleManager.particles.Add(new Warp(
                            entities[i].Position.X + Main.random.Next(-32, 32),
                            entities[i].Position.Y + Main.random.Next(-32, 32),
                            entities[i].Velocity.X - ((float)Main.random.NextDouble() * 5f),
                            entities[i].Velocity.Y - ((float)Main.random.NextDouble() * 5f),
                            0f, 0f,
                            ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                            ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                            0f,
                            0f, 0.01f, 1.8f, origin.TeamIndex, (isCrit ? 32 : 16) * finalDamage / MaxDamage,
                            Color.LimeGreen * 2f,
                            Color.Lerp(Color.SpringGreen, Color.ForestGreen, Utility.Map(finalDamage, MinDamage * CritBonus, MaxDamage * CritBonus, 0, 1)),
                            Color.Black,
                            50f, origin));
                    }
                }
            }
        }
        public override void Draw(SpriteBatch spritebatch, Entity origin)
        {
            
        }
        public override void DrawUI(SpriteBatch spritebatch)
        {
        }
    }
}