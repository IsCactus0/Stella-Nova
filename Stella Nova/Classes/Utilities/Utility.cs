using Microsoft.Xna.Framework;
using Stella_Nova.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stella_Nova.Classes.Utilities
{
    public static class Utility
    {
        public static object CloneObject(object objSource)
        {
            Type typeSource = objSource.GetType();
            object objTarget = Activator.CreateInstance(typeSource);

            PropertyInfo[] propertyInfo = typeSource.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (PropertyInfo property in propertyInfo)
            {
                if (property.CanWrite)
                {
                    if (property.PropertyType.IsValueType || property.PropertyType.IsEnum || property.PropertyType.Equals(typeof(string)))
                    {
                        property.SetValue(objTarget, property.GetValue(objSource, null), null);
                    }
                    else
                    {
                        object objPropertyValue = property.GetValue(objSource, null);
                        if (objPropertyValue == null)
                        {
                            property.SetValue(objTarget, null, null);
                        }
                        else
                        {
                            property.SetValue(objTarget, CloneObject(objPropertyValue), null);
                        }
                    }
                }
            }
            return objTarget;
        }
        public static Vector2 RotateVector(Vector2 vector, float degrees)
        {
            Vector2 result = new Vector2();
            result.X = vector.X * (float)Math.Cos(degrees) - vector.Y * (float)Math.Sin(degrees);
            result.Y = vector.X * (float)Math.Sin(degrees) + vector.Y * (float)Math.Cos(degrees);
            return result;
        }
        public static Vector2 RotateVector(Vector2 vector, float degrees, Vector2 origin)
        {
            vector -= origin;
            RotateVector(vector, degrees);
            return vector += origin;
        }
        public static Vector2 VectorXY(Vector3 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }
        public static Vector2 VectorXZ(Vector3 vector)
        {
            return new Vector2(vector.X, vector.Z);
        }
        public static Vector2 VectorYZ(Vector3 vector)
        {
            return new Vector2(vector.Y, vector.Z);
        }
        public static float Map(float value, float in1, float in2, float out1, float out2)
        {
            return (value - in1) / (in2 - in1) * (out2 - out1) + out1;
        }
        public static bool CalculateChancePerSecond(float delta, float probabilityPerSecond, float offset = 0f)
        {
            return (float)Main.random.NextDouble() + offset < delta * 60f * probabilityPerSecond;
        }
        public static List<SpaceObject> WithinBounds(QuadTree quadTree, Camera camera, int padding)
        {
            Rectangle viewport = new Rectangle()
            {
                X = camera.BoundingBox.X - padding,
                Y = camera.BoundingBox.Y - padding,
                Width = camera.BoundingBox.Width + padding * 2,
                Height = camera.BoundingBox.Height + padding * 2,
            };
        
            return quadTree.Query(viewport);
        }
        public static bool WithinBounds(SpaceObject spaceObject, Camera camera, int padding)
        {
            Rectangle viewport = new Rectangle()
            {
                X = camera.BoundingBox.X - padding,
                Y = camera.BoundingBox.Y - padding,
                Width = camera.BoundingBox.Width + padding * 2,
                Height = camera.BoundingBox.Height + padding * 2,
            };

            return viewport.Intersects(spaceObject.Polygon.Rectangle);
        }
        public static Vector2 RandomAlongBorder(Rectangle rectangle, Polygon polygon, int padding)
        {
            float buffer = 3f;
            Vector2 position = new Vector2(
                rectangle.X - padding,
                rectangle.Y - padding);

            switch (Main.random.Next(0, 4))
            {
                case 0:
                    // Along top...
                    position.X += Main.random.Next(0, rectangle.Width + padding * 2);
                    position.Y -= polygon.Rectangle.Height / 2 + buffer;
                    break;
                case 1:
                    // Along bottom...
                    position.X += Main.random.Next(0, rectangle.Width + padding * 2);
                    position.Y += rectangle.Height + polygon.Rectangle.Height / 2 + padding * 2 + buffer;
                    break;
                case 2:
                    // Along left...
                    position.X -= polygon.Rectangle.Width / 2 + buffer;
                    position.Y += Main.random.Next(0, rectangle.Height + padding * 2);
                    break;
                default:
                    // Along right...
                    position.X += rectangle.Width + polygon.Rectangle.Width / 2 + padding * 2 + buffer;
                    position.Y += Main.random.Next(0, rectangle.Height + padding * 2);
                    break;
            }

            return position;
        }
        public static Vector2 RandomAlongBorder(Rectangle rectangle, float offset, int padding)
        {
            float buffer = 3f;
            Vector2 position = new Vector2(
                rectangle.X - padding,
                rectangle.Y - padding);

            switch (Main.random.Next(0, 4))
            {
                case 0:
                    // Along top...
                    position.X += Main.random.Next(0, rectangle.Width + padding * 2);
                    position.Y -= offset + buffer;
                    break;
                case 1:
                    // Along bottom...
                    position.X += Main.random.Next(0, rectangle.Width + padding * 2);
                    position.Y += rectangle.Height + offset + padding * 2 + buffer;
                    break;
                case 2:
                    // Along left...
                    position.X -= offset + buffer;
                    position.Y += Main.random.Next(0, rectangle.Height + padding * 2);
                    break;
                default:
                    // Along right...
                    position.X += rectangle.Width + offset + padding * 2 + buffer;
                    position.Y += Main.random.Next(0, rectangle.Height + padding * 2);
                    break;
            }

            return position;
        }
    }
}