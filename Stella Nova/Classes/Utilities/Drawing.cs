using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Utilities
{
    public static class Drawing
    {
        // Shapes...
        public static List<Vector2> Rectangle(float size)
        {
            return Rectangle(size, size, size / -2, size / -2);
        }
        public static List<Vector2> Rectangle(float width, float height)
        {
            return Rectangle(width, height, width / -2, height / -2);
        }
        public static List<Vector2> Rectangle(float width, float height, float offsetX, float offsetY)
        {
            List<Vector2> vertices = new List<Vector2>()
            {
                new Vector2(offsetX, offsetY),
                new Vector2(offsetX + width, offsetY),
                new Vector2(offsetX + width, offsetY + height),
                new Vector2(offsetX, offsetY + height),
            };

            return vertices;
        }
        public static List<Vector2> Ellipse(float radius, float detail)
        {
            return Ellipse(radius * 2f, radius * 2f, detail, 0, 0);
        }
        public static List<Vector2> Ellipse(float width, float height, float detail)
        {
            return Ellipse(width, height, detail, 0, 0);
        }
        public static List<Vector2> Ellipse(float width, float height, float detail, float offsetX, float offsetY)
        {
            List<Vector2> vertices = new List<Vector2>();
            for (float angle = 0; angle < MathHelper.TwoPi; angle += MathHelper.TwoPi / detail)
                vertices.Add(new Vector2(
                    offsetX + (width / 2) * (float)Math.Cos(angle),
                    offsetY + (height / 2) * (float)Math.Sin(angle)));

            return vertices;
        }
        public static List<Vector2> Cross(float size)
        {
            return new List<Vector2>()
            {
                new Vector2(-size, -size),
                new Vector2(size, size)
            };
        }
        public static List<Vector2> Asteroid(float radius, float detail, float roughness, int resolution, OpenSimplexNoise noise, Random random)
        {
            List<Vector2> vertices = new List<Vector2>();
            int randomOriginX = random.Next();
            int randomOriginY = random.Next();

            for (int i = 0; i < resolution; i++)
            {
                float angle = MathHelper.TwoPi / resolution * i;
                float offset = (float)noise.Evaluate(Math.Cos(angle) * detail + randomOriginX, Math.Sin(angle) * detail + randomOriginY);

                vertices.Add(new Vector2(
                    (radius + offset * roughness) * (float)Math.Cos(angle),
                    (radius + offset * roughness) * (float)Math.Sin(angle)));
            }

            return vertices;
        }
        public static List<Vector2> Asteroid(float radius, float detail, float roughness, int resolution, Vector2 origin, OpenSimplexNoise noise, Random random)
        {
            List<Vector2> vertices = new List<Vector2>();

            for (int i = 0; i < resolution; i++)
            {
                float angle = MathHelper.TwoPi / resolution * i;
                float offset = (float)noise.Evaluate(Math.Cos(angle) * detail + origin.X, Math.Sin(angle) * detail + origin.Y);

                vertices.Add(new Vector2(
                    (radius + offset * roughness) * (float)Math.Cos(angle),
                    (radius + offset * roughness) * (float)Math.Sin(angle)));
            }

            return vertices;
        }

        // Textures...
        public static Texture2D Blur(int radius)
        {
            return Blur(radius, Color.White);
        }
        public static Texture2D Blur(int radius, Color colour)
        {
            int length = radius * 2;
            Color[] colors = new Color[length * length];

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    float distance = Vector2.Distance(Vector2.One, new Vector2(x, y) / radius);
                    float alpha = FallOffBlur(distance);
                    colors[y * length + x] = colour;
                    colors[y * length + x].A = (byte)MathHelper.Clamp(alpha * 256f + 0.5f, 0f, 255f);
                }
            }

            Texture2D tex = new Texture2D(Main.graphics.GraphicsDevice, radius * 2, radius * 2);
            tex.SetData(colors);
            return tex;
        }
        public static Texture2D Circle(int radius, Color colour)
        {
            int length = radius * 2;
            Color[] colors = new Color[length * length];

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    float distance = Vector2.Distance(Vector2.One, new Vector2(x, y) / radius);
                    float alpha = FallOffCircle(distance);
                    colors[y * length + x] = colour;
                    colors[y * length + x].A = (byte)MathHelper.Clamp(alpha * 256f + 0.5f, 0f, 255f);
                }
            }

            Texture2D tex = new Texture2D(Main.graphics.GraphicsDevice, radius * 2, radius * 2);
            tex.SetData(colors);
            return tex;
        }
        public static Texture2D SinBlur(int radius, Color colour)
        {
            int length = radius * 2;
            float maxLength = new Vector2(radius, radius).Length();
            Color[] colors = new Color[length * length];

            for (int y = -radius; y < radius; y++)
            {
                for (int x = -radius; x < radius; x++)
                {
                    float distance = new Vector2(x, y).Length() / maxLength;
                    distance = Utility.Map(distance, 0f, 1f, 0.5f, 2f);
                    byte alpha = (byte)MathHelper.Clamp((float)Math.Sin(distance * MathHelper.TwoPi) * 255f, 0f, 255f);
                    colors[(y + radius) * length + (x + radius)] = colour;
                    colors[(y + radius) * length + (x + radius)].A = alpha;
                }
            }

            Texture2D tex = new Texture2D(Main.graphics.GraphicsDevice, radius * 2, radius * 2);
            tex.SetData(colors);
            return tex;
        }
        public static Texture2D Vignette(int width, int height, Color colour)
        {
            Color[] colors = new Color[width * height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    float distance = Vector2.Distance(new Vector2(width / 2f, height / 2f), new Vector2(x, y)) / (height * 2);
                    float alpha = FallOffBlur(distance);
                    colors[y * width + x] = colour;
                    colors[y * width + x].A = (byte)(255f - MathHelper.Clamp(alpha * 256f + 0.5f, 0f, 255f));
                }
            }

            Texture2D tex = new Texture2D(Main.graphics.GraphicsDevice, width, height);
            tex.SetData(colors);
            return tex;
        }
        public static Texture2D Cloud(int radius, Color colour, float frequency = 0.5f)
        {
            int length = radius * 2;
            Color[] colors = new Color[length * length];

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    float distance = Vector2.Distance(Vector2.One, new Vector2(x, y) / radius);
                    float alpha = Math.Min(FallOffBlur(distance), (float)Main.openSimplexNoise.Evaluate(x * frequency, y * frequency));
                    colors[y * length + x] = colour;
                    colors[y * length + x].A = (byte)MathHelper.Clamp(alpha * 256f + 0.5f, 0f, 255f);
                }
            }

            Texture2D tex = new Texture2D(Main.graphics.GraphicsDevice, radius * 2, radius * 2);
            tex.SetData(colors);
            return tex;
        }
        public static Texture2D Cloud(int radius, Color colour, Vector3 offset, float frequency = 0.5f)
        {
            int length = radius * 2;
            Color[] colors = new Color[length * length];

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    float distance = Vector2.Distance(Vector2.One, new Vector2(x, y) / radius);
                    float alpha = Math.Min(FallOffBlur(distance), (float)Main.openSimplexNoise.Evaluate(x * frequency + offset.X, y * frequency + offset.X, offset.Z));
                    colors[y * length + x] = colour;
                    colors[y * length + x].A = (byte)MathHelper.Clamp(alpha * 256f + 0.5f, 0f, 255f);
                }
            }

            Texture2D tex = new Texture2D(Main.graphics.GraphicsDevice, radius * 2, radius * 2);
            tex.SetData(colors);
            return tex;
        }

        public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color colour, float thickness = 1f)
        {
            var distance = Vector2.Distance(start, end);
            var angle = (float)Math.Atan2(end.Y - start.Y, end.X - start.X);
            var origin = new Vector2(0f, 0.5f);
            var scale = new Vector2(distance, thickness);

            spriteBatch.Draw(Main.basic, start, null, colour, angle, origin, scale, SpriteEffects.None, 0);
        }
        public static void DrawRect(SpriteBatch spriteBatch, Rectangle rectangle, Color color)
        {
            spriteBatch.Draw(Main.basic, rectangle.Location.ToVector2(), color);
        }

        private static float FallOffBlur(float distance)
        {
            return FallOffBlur(distance, 1f, 1f);
        }
        private static float FallOffBlur(float distance, float maxDistance, float scalingFactor)
        {
            if (distance <= maxDistance / 3)
            {
                return scalingFactor * (1 - 3 * distance * distance / (maxDistance * maxDistance));
            }
            else if (distance <= maxDistance)
            {
                float x = 1 - distance / maxDistance;
                return (3f / 2f) * scalingFactor * x * x;
            }
            else return 0;
        }
        private static float FallOffCircle(float distance)
        {
            return FallOffCircle(distance, 1f);
        }
        private static float FallOffCircle(float distance, float maxDistance)
        {
            if (distance <= maxDistance)
                return 1;
            else return 0;
        }
    }
}