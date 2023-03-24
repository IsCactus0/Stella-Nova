using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Entities;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Objects.Particles.Types;
using Stella_Nova.Classes.Objects.Projectiles;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Effects
{
    public class Shield : Status
    {
        public Shield()
        {
            Radius = 128;
            MaxRadius = Radius;
            Strength = 1000;
            MaxStrength = Strength;
            LastHit = 0f;
            ChargeTime = 3f;
            UseTime = 10f;
            Time = 0f;
            MaxTime = 500f;
            isActive = true;

            Polygon = new Polygon(Vector3.Zero, GenerateShape());
        }

        public float Radius;
        public float MaxRadius;
        public float Strength;
        public float MaxStrength;
        public float LastHit;
        public float ChargeTime;
        private float offsetX;
        private float offsetY;
        private float size;

        public override List<Vector2> GenerateShape()
        {
            List<Vector2> vertices = new List<Vector2>();
            for (float angle = 0; angle < MathHelper.TwoPi; angle += MathHelper.TwoPi / 128)
            {
                Vector2 vertice = new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));
                vertice *= Radius + (float)Main.openSimplexNoise.Evaluate(vertice.X + offsetX, vertice.Y + offsetY) * (Radius / 4f * size);
                vertices.Add(vertice);
            }

            return vertices;
        }
        public override void Update(float delta, Entity origin)
        {
            base.Update(delta, origin);

            Polygon.Origin = origin.Polygon.Origin;
            // Polygon.SetRotation(0, Time, Time / 2f);
            // Polygon.ApplyTransforms();

            size = (float)Math.Cos(Time * (1f - Strength / MaxStrength)) * (1f - Strength / MaxStrength);

            offsetX += delta / Radius * 10f;
            offsetY += delta / Radius * 10f;
            
            // Polygon.OriginalVertices = new List<Vector3>();
            // foreach (Vector2 vertice in GenerateShape())
            //     Polygon.OriginalVertices.Add(new Vector3(vertice.X, vertice.Y, 0));

            LastHit += delta;
            
            // If the shield is not full strength...
            if (Strength < MaxStrength)
            {
                // ...and has been destroyed...
                if (Strength <= 0)
                {
                    // ...start adding to the time it was last used so it can recharge.
                    LastUsed += delta;
                    Strength = 0;
                    return;
                }
                // ...and hasn't been hit for as long as it's charge time
                else if (LastHit >= ChargeTime)
                {
                    // Start repairing to the shield exponentially.
                    Strength += (LastHit - ChargeTime);
                }

                // ...and has been down for longer than it's use time...
                if (LastUsed > UseTime)
                {
                    // ...grow the shield over time.
                    Strength += delta * MaxStrength;
                    // Radius = MaxRadius * (Strength / MaxStrength);
                    if (Strength >= MaxStrength)
                    {
                        LastUsed = 0;
                        Strength = MaxStrength;
                        Radius = MaxRadius;
                    }
                }
            }

            if (Utility.CalculateChancePerSecond(delta, (1f - Strength / MaxStrength)))
            {
                float tempAngle = (float)Main.random.NextDouble() * MathHelper.TwoPi;

                ParticleManager.particles.Add(new Warp(
                    origin.Position.X + (float)Math.Cos(tempAngle) * Radius,
                    origin.Position.Y + (float)Math.Sin(tempAngle) * Radius,
                    (float)Math.Cos(tempAngle + MathHelper.PiOver2) * 200f,
                    (float)Math.Sin(tempAngle + MathHelper.PiOver2) * 200f,
                    0f, 0f,
                    ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                    ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                    0f,
                    0, 0.1f, 3f, origin.TeamIndex - 1, Main.random.Next(2, 12),
                    Color.LightYellow,
                    Color.FromNonPremultiplied(232, 156, 1, 256),
                    Color.Coral * 0.25f,
                    10f, origin));
            }

            List<SpaceObject> spaceObjects =
                        AsteroidManager.FindAll(origin.Position, Radius).Cast<SpaceObject>()
                .Concat(EntityManager.FindAll(origin.Position, Radius))
                .Concat(ParticleManager.FindAll(origin.Position, Radius))
                .Concat(ProjectileManager.FindAll(origin.Position, Radius)).ToList();

            if (spaceObjects.Count > 0)
            {
                for (int i = 0; i < spaceObjects.Count; i++)
                {
                    if (spaceObjects[i].Position == origin.Position ||
                        (spaceObjects[i] is Entity && ((Entity)spaceObjects[i]).TeamIndex == origin.TeamIndex) ||
                        (spaceObjects[i] is Projectile && ((Projectile)spaceObjects[i]).TeamIndex == origin.TeamIndex) ||
                        (spaceObjects[i] is Particle && ((Particle)spaceObjects[i]).TeamIndex == origin.TeamIndex) ||
                        (spaceObjects[i].Mass >= float.PositiveInfinity))
                            continue;
            
                    LastHit = 0f;
            
                    float difference = (origin.Velocity - spaceObjects[i].Velocity).Length();
            
                    // Vector pointing towards target (spaceObjects[i])...
                    Vector2 direction = spaceObjects[i].Position - origin.Position;
                    // Normalise to get just directional information...
                    direction.Normalize();
            
                    float force = spaceObjects[i].Mass * difference / 400f;
                    if (spaceObjects[i] is Projectile)
                        force = ((Projectile)spaceObjects[i]).MaxDamage / 8f;
                    else if (spaceObjects[i] is Particle)
                        force = 0f;
                    Strength -= force;
            
                    // If the shield breaks create more particles...
                    if (Strength <= 0)
                        force = 10f;

                    for (int j = 0; j < force; j++)
                    {
                        float angle = (float)Math.Atan2(direction.Y, direction.X);
                        float offset = (float)((Main.random.NextDouble() - 0.5f) * (j / (spaceObjects[i].Mass))) * MathHelper.PiOver4;
                        angle += offset;

                        ParticleManager.particles.Add(new Warp(
                            origin.Position.X + (float)Math.Cos(angle) * Radius,
                            origin.Position.Y + (float)Math.Sin(angle) * Radius,
                            origin.Velocity.X + (float)Math.Cos(angle) * 300f,
                            origin.Velocity.Y + (float)Math.Sin(angle) * 300f,
                            0f, 0f,
                            ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                            ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                            0f,
                            0, 0.1f, 3f, origin.TeamIndex - 1, Main.random.Next(2, 12),
                            Color.LightYellow,
                            Color.FromNonPremultiplied(232, 156, 1, 256),
                            Color.Coral * 0.25f,
                            30f, origin));
                    }
            
                    if (spaceObjects[i].Mass < float.PositiveInfinity && spaceObjects[i].Mass > 0)
                    {
                        spaceObjects[i].Velocity = (direction * (difference + origin.Velocity.Length()));
                        spaceObjects[i].Velocity *= 0.8f;
                    }
            
                    if (spaceObjects[i] is Entity)
                    {
                        // If the difference in velocities exceeds 250 cause damage
                        if (difference > 250)
                        {
                            int damage = (int)Math.Clamp((difference - 249f) / 10f, 0, 500);
                            ((Entity)spaceObjects[i]).Damage(damage, 0, 500, 0f, false, origin.TeamIndex, origin.Position + direction * Radius);
                        }                        
                    }
                    if (spaceObjects[i] is Projectile)
                    {
                        ((Projectile)spaceObjects[i]).Penetration -= 1;
                        if (((Projectile)spaceObjects[i]).Penetration > 0)
                            ((Projectile)spaceObjects[i]).TeamIndex = origin.TeamIndex;
                    }

                    // Multiply by radius to get offset of asteroid...
                    if (spaceObjects[i] is Asteroid)
                        direction *= Radius + ((Asteroid)spaceObjects[i]).Radius;
                    else direction *= Radius;

                    spaceObjects[i].Position = origin.Position + direction;

                    if (Strength <= 0)
                        return;
                }
            }
        }
        public override void Draw(SpriteBatch spriteBatch, Entity origin)
        {
            if (Strength <= 0f)
                return;

            // float resolution = 12;
            Polygon.Draw(spriteBatch, Color.FromNonPremultiplied(232, 156, 1, 256) * 0.5f, 1.5f);
            // for (int i = 0; i < resolution; i++)
            // {
            //     Polygon.Rotate(MathHelper.TwoPi / resolution, Axis.X);
            //     Polygon.ApplyTransforms();
            //     if (i == resolution / 6) Polygon.Draw(spriteBatch, Color.FromNonPremultiplied(232, 156, 1, 256) * 0.25f, 1.5f);
            //     else Polygon.Draw(spriteBatch, Color.White * 0.5f, 1.5f);
            // }
            // for (int i = 0; i < resolution; i++)
            // {
            //     Polygon.Rotate(MathHelper.TwoPi / resolution, Axis.Y);
            //     Polygon.ApplyTransforms();
            //     if (i == resolution / 6) Polygon.Draw(spriteBatch, Color.FromNonPremultiplied(232, 156, 1, 256) * 0.25f, 1.5f);
            //     else Polygon.Draw(spriteBatch, Color.White * 0.5f, 1.5f);
            // }
        }
        public override void DrawUI(SpriteBatch spriteBatch)
        {
            string text = $"{(int)((Strength / MaxStrength) * 100f)}%";
            Vector2 textSize = UIManager.Roboto_Medium.MeasureString(text) * 0.17f;
            Vector2 centre = new Vector2(Main.graphics.PreferredBackBufferWidth / 16f, Main.graphics.PreferredBackBufferHeight - Main.graphics.PreferredBackBufferWidth / 16f);

            centre = new Vector2(
                Main.graphics.PreferredBackBufferWidth / 16f + 170,
                Main.graphics.PreferredBackBufferHeight - Main.graphics.PreferredBackBufferWidth / 16f + 40);

            spriteBatch.DrawString(
                UIManager.Roboto_Light, text,
                new Vector2(centre.X - textSize.X / 2f, centre.Y - textSize.Y / 2f),
                Color.PowderBlue, 0f, Vector2.Zero, 0.17f, SpriteEffects.None, 0);
            
            int dials = 25;
            int startOffset = 2;
            int endOffset = 1;
            int total = dials - startOffset - endOffset;

            for (int i = startOffset; i < dials - endOffset; i++)
            {
                float angle = (MathHelper.TwoPi / dials) * i;
                if ((float)(i - startOffset) / total < (Strength / MaxStrength))
                Drawing.DrawLine(spriteBatch,
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 50,
                        centre.Y + (float)Math.Sin(angle) * 50),
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 60,
                        centre.Y + (float)Math.Sin(angle) * 60),
                    Color.Lerp(Color.Coral, Color.SpringGreen, Strength / MaxStrength), 5f);
                else
                Drawing.DrawLine(spriteBatch,
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 50,
                        centre.Y + (float)Math.Sin(angle) * 50),
                    new Vector2(
                        centre.X + (float)Math.Cos(angle) * 60,
                        centre.Y + (float)Math.Sin(angle) * 60),
                    Color.Lerp(Color.Coral, Color.SpringGreen, Strength / MaxStrength) * 0.4f, 4f);

                if (i % 2f == 0)
                Drawing.DrawLine(spriteBatch,
                new Vector2(
                    centre.X + (float)Math.Cos(angle) * 32,
                    centre.Y + (float)Math.Sin(angle) * 32),
                new Vector2(
                    centre.X + (float)Math.Cos(angle) * 38,
                    centre.Y + (float)Math.Sin(angle) * 38),
                Color.White * 0.5f, 10f);
            }
        }
        public override void Reset()
        {
            Strength = MaxStrength;
            Radius = MaxRadius;
            LastUsed = 0f;
            LastHit = 0f;
            base.Reset();
        }
    }
}