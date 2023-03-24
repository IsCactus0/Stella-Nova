using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Effects
{
    public class Burning : Status
    {
        public Burning()
            : base()
        {
            MinDamage = 2;
            MaxDamage = 6;
            CritChance = 0.2f;
            CritBonus = 1.2f;
            UseTime = 0.5f;
            MaxTime = 100f;
        }
        public Burning(float useTime)
            : base(useTime)
        {
            MinDamage = 2;
            MaxDamage = 6;
            CritChance = 0.2f;
            CritBonus = 1.2f;
        }
        public Burning(float useTime, int damage)
            : base(useTime)
        {
            MinDamage = damage;
            MaxDamage = damage;
            CritChance = 0.2f;
            CritBonus = 1.2f;
        }
        public Burning(float useTime, int minDamage, int maxDamage)
            : base(useTime)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CritChance = 0.2f;
            CritBonus = 1.2f;
        }
        public Burning(float useTime, int minDamage, int maxDamage, float critChance)
            : base(useTime)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CritChance = critChance;
            CritBonus = 1.2f;
        }
        public Burning(float useTime, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(useTime)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            CritChance = critChance;
            CritBonus = critBonus;
        }

        public int MinDamage;
        public int MaxDamage;
        public float CritChance;
        public float CritBonus;

        public override List<Vector2> GenerateShape()
        {
            return Drawing.Ellipse(30, 30);
        }
        public override void Update(float delta, Entity origin)
        {
            LastUsed += delta;
            if (LastUsed >= UseTime)
            {
                LastUsed = 0;
                int damage = Main.random.Next(MinDamage, MaxDamage);
                bool isCrit = Main.random.NextDouble() < CritChance;

                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 70f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * 70f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));


                origin.Damage(damage, MinDamage, MaxDamage, CritBonus, isCrit, -10, origin.Position + randomOffset);
            }

            if (Utility.CalculateChancePerSecond(delta, 0.8f))
            for (int i = 0; i < 50f * (1f - Time / MaxTime); i++)
            {
                Vector3 position = origin.Polygon.CurrentVertices[Main.random.Next(origin.Polygon.CurrentVertices.Count)];
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 12f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * 12f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                ParticleManager.particles.Add(
                    new Spark(
                        origin.Position.X + position.X + randomOffset.X,
                        origin.Position.Y + position.Y + randomOffset.Y,
                        randomOffset.X * 5f,
                        randomOffset.Y * 5f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.05f,
                        0.5f + (float)Main.random.NextDouble() / 10f, origin.TeamIndex - 1, Main.random.Next(12, 32),
                        Color.OrangeRed, Color.LightGoldenrodYellow, Color.Maroon));
                    ParticleManager.particles.Add(
                        new Smoke(
                            origin.Position.X + position.X,
                            origin.Position.Y + position.Y,
                            randomOffset.X * 5f,
                            randomOffset.Y * 5f,
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.05f,
                            1.5f + (float)Main.random.NextDouble() / 10f, origin.TeamIndex - 1, Main.random.Next(48, 64),
                            Color.Gray * 0.1f, Color.Black));
            }

            base.Update(delta, origin);
        }
        public override void Draw(SpriteBatch spritebatch, Entity origin)
        {
        }
        public override void DrawUI(SpriteBatch spritebatch)
        {

        }
    }
}
