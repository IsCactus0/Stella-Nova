using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Particles;
using Stella_Nova.Classes.Objects.Projectiles;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Nova.Classes.Objects.Abilities
{
    public class Shield : Ability
    {
        public Shield()
        {
            Radius = 128;
            MaxRadius = Radius;
            Strength = 10000;
            MaxStrength = Strength;
            LastHit = 0f;
            ChargeTime = 3f;
            UseTime = 10f;
            isActive = true;
        }

        public float Radius;
        public float MaxRadius;

        public float Strength;
        public float MaxStrength;

        public float LastHit;
        public float ChargeTime;

        public override void Update(float delta, Entity origin)
        {
            LastHit += delta;
            
            // If the shield is not full strength...
            if (Strength < MaxStrength)
            {
                // ...and has been down for longer than it's use time...
                if (LastUsed > UseTime)
                {
                    // ...grow the shield over time.
                    Strength += delta * MaxStrength;
                    Radius = MaxRadius * (Strength / MaxStrength);
                    if (Strength >= MaxStrength)
                    {
                        LastUsed = 0;
                        Strength = MaxStrength;
                        Radius = MaxRadius;
                    }
                }

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
            }

            List<SpaceObject> spaceObjects = AsteroidManager.FindAll(origin.Position, Radius).Cast<SpaceObject>()
                .Concat(EntityManager.FindAll(origin.Position, Radius))
                .Concat(ParticleManager.FindAll(origin.Position, Radius))
                .Concat(ProjectileManager.FindAll(origin.Position, Radius)).ToList();

            if (spaceObjects.Count > 0)
            {
                for (int i = 0; i < spaceObjects.Count; i++)
                {
                    if (spaceObjects[i].Position == origin.Position ||
                        (spaceObjects[i] is Projectile && ((Projectile)spaceObjects[i]).TeamIndex == origin.TeamIndex) ||
                        (spaceObjects[i] is Particle && ((Particle)spaceObjects[i]).TeamIndex == origin.TeamIndex) ||
                        (spaceObjects[i].Mass >= float.PositiveInfinity))
                            continue;

                    LastHit = 0f;

                    float targetSpeed = spaceObjects[i].Velocity.Length();
                    float difference = (origin.Velocity - spaceObjects[i].Velocity).Length();

                    // Vector pointing towards target (spaceObjects[i])...
                    Vector2 direction = spaceObjects[i].Position - origin.Position;
                    // Normalise to get just directional information...
                    direction.Normalize();

                    float force = spaceObjects[i].Mass * difference / 200f;
                    if (spaceObjects[i] is Projectile)
                        force = ((Projectile)spaceObjects[i]).MaxDamage / 4f;
                    Strength -= force;

                    // If the shield breaks create more particles...
                    if (Strength <= 0)
                        force = 30f;

                    for (int j = 0; j < force; j++)
                    {
                        float angle = (float)Math.Atan2(direction.Y, direction.X);
                        float offset = (float)((Main.random.NextDouble() - 0.5f) * (j / (spaceObjects[i].Mass))) * MathHelper.PiOver4;
                        angle += offset;

                        ParticleManager.particles.Add(new Warp(
                            origin.Position.X + (float)Math.Cos(angle) * Radius,
                            origin.Position.Y + (float)Math.Sin(angle) * Radius,
                            origin.Velocity.X,
                            origin.Velocity.Y,
                            0f, 0f,
                            ((float)Main.random.NextDouble() * MathHelper.PiOver2) - MathHelper.PiOver4,
                            ((float)Main.random.NextDouble() - 0.5f) * 0.75f,
                            0f,
                            0, 0.01f, 0.3f, -1, Main.random.Next(2, 12),
                            Color.Lerp(Color.LightSeaGreen, Color.Chocolate, 1f - Strength / MaxStrength),
                            Color.Lerp(Color.SpringGreen, Color.Coral, 1f - Strength / MaxStrength),
                            Color.Lerp(Color.SeaGreen, Color.SaddleBrown, 1f - Strength / MaxStrength) * 0.25f,
                            10f, origin));
                    }

                    if (spaceObjects[i].Mass < float.PositiveInfinity && spaceObjects[i].Mass > 0)
                    {
                        spaceObjects[i].Velocity = (direction * (targetSpeed + origin.Velocity.Length()));
                        spaceObjects[i].Velocity *= 0.8f;
                    }

                    // Multiply by radius to get offset of asteroid...
                    if (spaceObjects[i] is Asteroid)
                        direction *= Radius + ((Asteroid)spaceObjects[i]).Radius;
                    else direction *= Radius;
                    spaceObjects[i].Position = origin.Position + direction;

                    if (spaceObjects[i] is Entity)
                    {
                        // If the difference in velocities exceeds 150 cause damage
                        if (difference > 250)
                        {
                            int damage = (int)Math.Clamp((difference - 250f) / 10f, 0, 250);
                            ((Entity)spaceObjects[i]).Damage(damage, 0, 250, 0f, false, origin.TeamIndex, direction);
                        }                        
                    }
                    if (spaceObjects[i] is Projectile)
                    {
                        ((Projectile)spaceObjects[i]).Penetration -= 1;
                        // if (((Projectile)spaceObjects[i]).Penetration > 0)
                        //     ((Projectile)spaceObjects[i]).TeamIndex = TeamIndex;
                    }
                }
            }
        }
        public override void Draw(SpriteBatch spriteBatch, Entity origin)
        {
            // if (Strength <= 0f)
            //     return;
            // 
            // int detail = (int)Radius;
            // for (int i = 0; i < detail; i++)
            // {
            //     float angle = MathHelper.TwoPi / detail;
            //     Drawing.DrawLine(spriteBatch,
            //         new Vector2(
            //             origin.Position.X + (float)Math.Cos(angle * i) * Radius,
            //             origin.Position.Y + (float)Math.Sin(angle * i) * Radius),
            //         new Vector2(
            //             origin.Position.X + (float)Math.Cos(angle * (i + 1)) * Radius,
            //             origin.Position.Y + (float)Math.Sin(angle * (i + 1)) * Radius),
            //         Color.Lerp(Color.Cyan, Color.Coral, 1f - Strength / MaxStrength) * (0.2f + 0.2f * (Strength / MaxStrength)), 3f);
            // }
        }
        public override void DrawUI(SpriteBatch spriteBatch)
        {
            string text = $"{(int)((Strength / MaxStrength) * 100f)}%";
            Vector2 textSize = Main.Roboto_Medium.MeasureString(text) * 0.17f;
            Vector2 centre = new Vector2(Main.graphics.PreferredBackBufferWidth / 16f, Main.graphics.PreferredBackBufferHeight - Main.graphics.PreferredBackBufferWidth / 16f);

            centre = new Vector2(
                Main.graphics.PreferredBackBufferWidth / 16f + 170,
                Main.graphics.PreferredBackBufferHeight - Main.graphics.PreferredBackBufferWidth / 16f + 40);

            spriteBatch.DrawString(
                Main.Roboto_Light, text,
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