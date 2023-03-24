using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Objects.Asteroids;
using Stella_Nova.Classes.Objects.Particles.Types;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Projectiles.Types
{
    public class Spectrum : HomingProjectile
    {
        public Spectrum()
        {

        }
        public Spectrum(float x, float y)
            : base(x, y)
        {

        }
        public Spectrum(float x, float y, float vx, float vy)
            : base(x, y, vx, vy)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay)
            : base(x, y, vx, vy, ax, ay)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle)
            : base(x, y, vx, vy, ax, ay, angle)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage)
        {
        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange)
        {

        }
        public Spectrum(float x, float y, float vx, float vy, float ax, float ay, float angle, float vangle, float aangle, float mass, float friction, int playerIndex, int penetration, int minDamage, int maxDamage, float critChance, float critBonus, float maxLifespan, float trackingStrength, float trackingRange, SpaceObject target)
            : base(x, y, vx, vy, ax, ay, angle, vangle, aangle, mass, friction, playerIndex, penetration, minDamage, maxDamage, critChance, critBonus, maxLifespan, trackingStrength, trackingRange, target)
        {

        }

        public List<Color> Colours = new List<Color>()
        {
            Color.Firebrick,
            Color.Tomato,
            Color.Gold,
            Color.LimeGreen,
            Color.DeepSkyBlue,
            Color.DarkBlue,
            Color.Indigo,
        };
        private Color currentColour = Color.White;
        private int colourIndex;
        private float lastSwitched;
        private float frequency = 0.3f;

        public override void FindCollisions()
        {
            foreach (Asteroid asteroid in AsteroidManager.FindAll(this))
            {
                for (int i = 0; i < 100; i++)
                {
                    float angle = i * 100 / MathHelper.Pi;

                    ParticleManager.particles.Add(
                    new Spark(
                        asteroid.Position.X + (float)Math.Cos(angle) * asteroid.Radius,
                        asteroid.Position.Y + (float)Math.Sin(angle) * asteroid.Radius,
                        0f, 0f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.75f, 1f + (float)Main.random.NextDouble() / 5f, TeamIndex, 24,
                        Color.Black, Color.Lerp(currentColour, Colours[colourIndex], lastSwitched / frequency), Color.Black));
                }

                AsteroidManager.asteroids.Remove(asteroid);

                Penetration--;
                if (Penetration <= 0)
                {
                    this.Destroy();
                    break;
                }
            }
        }
        public override void Destroy()
        {
            for (int i = 0; i < Main.random.Next(48, 64); i++)
            {
                Vector2 randomOffset = new Vector2(
                    (float)Main.random.NextDouble() * 64f * (float)Math.Cos(Main.random.NextDouble() * Math.PI * 2),
                    (float)Main.random.NextDouble() * 64f * (float)Math.Sin(Main.random.NextDouble() * Math.PI * 2));

                ParticleManager.particles.Add(
                    new Spark(
                        Position.X + randomOffset.X,
                        Position.Y + randomOffset.Y,
                        randomOffset.X * 5f,
                        randomOffset.Y * 5f,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.1f,
                        1f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(2, 12),
                        Color.Gold, Color.Maroon, Color.Black));

                ParticleManager.particles.Add(
                    new Smoke(
                        Position.X - randomOffset.X,
                        Position.Y - randomOffset.Y,
                        -randomOffset.X,
                        -randomOffset.Y,
                        0f, 0f,
                        (float)Main.random.NextDouble() - 0.5f,
                        (float)Main.random.NextDouble() - 0.5f,
                        0f, 10f, 0.2f,
                        0.3f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(48, 64),
                        Color.Peru, Color.Black));

                if (Main.random.Next(6) == 0)
                {
                    ParticleManager.particles.Add(
                        new Spark(
                            Position.X,
                            Position.Y,
                            randomOffset.X * -10f * Main.random.Next(1, 4),
                            randomOffset.Y * -10f * Main.random.Next(1, 4),
                            0f, 0f,
                            (float)Main.random.NextDouble() - 0.5f,
                            (float)Main.random.NextDouble() - 0.5f,
                            0f, 10f, 0.1f,
                            1f + (float)Main.random.NextDouble() / 2f, TeamIndex, Main.random.Next(2, 12),
                            Color.White, Color.Gold, Color.Maroon));
                }
            }

            base.Destroy();
        }
        public override void Update(float delta)
        {
            lastSwitched += delta;

            frequency = 32f / Velocity.Length();

            if (lastSwitched > frequency)
            {
                lastSwitched = 0f;
                currentColour = Colours[colourIndex];
                colourIndex++;
                if (colourIndex >= Colours.Count)
                    colourIndex = 0;
            }

            ParticleManager.particles.Add(
                new Spark(
                    Position.X,
                    Position.Y,
                    0f, 0f,
                    0f, 0f,
                    (float)Main.random.NextDouble() - 0.5f,
                    (float)Main.random.NextDouble() - 0.5f,
                    0f, 0.1f, 0.75f, 1f + (float)Main.random.NextDouble() / 5f, TeamIndex, 24,
                    Color.Black, Color.Lerp(currentColour, Colours[colourIndex], lastSwitched / frequency), Color.Black));

            base.Update(delta);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
        }
    }
}