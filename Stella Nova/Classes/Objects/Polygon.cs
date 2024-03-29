﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Enums;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects
{
    public class Polygon
    {
        public Polygon(Vector3 origin)
        {
            Origin = origin;
            OriginalVertices = new List<Vector3>();
            CurrentVertices = new List<Vector3>();
        }
        public Polygon(Vector3 origin, List<Vector2> vertices)
        {
            Origin = origin;
            OriginalVertices = new List<Vector3>();
            CurrentVertices = new List<Vector3>();
            for (int i = 0; i < vertices.Count; i++)
            {
                OriginalVertices.Add(new Vector3(vertices[i].X, vertices[i].Y, 0));
                CurrentVertices.Add(new Vector3(vertices[i].X, vertices[i].Y, 0));
            }

            MaxZDepth = FindFurthestPoint();
        }

        public List<Vector3> OriginalVertices;
        public List<Vector3> CurrentVertices;
        
        public Vector3 Origin;
        public Vector3 Offset;

        public float ScaleX = 1f;
        public float ScaleY = 1f;
        public float ScaleZ = 1f;
        
        public float Roll;
        public float Pitch;
        public float Yaw;

        public float MaxZDepth;
        public Rectangle Rectangle
        {
            get { return GetBoundingBox(); }
        }

        public void Draw(SpriteBatch spriteBatch, Color colour, float strokeWeight = 3f)
        {
            if (CurrentVertices.Count > 0)
            {
                Drawing.DrawLine(spriteBatch,
                    Utility.VectorXY(CurrentVertices[CurrentVertices.Count - 1] + Origin),
                    Utility.VectorXY(CurrentVertices[0] + Origin),
                    colour, strokeWeight);

                for (int v = 0; v < CurrentVertices.Count - 1; v++)
                    Drawing.DrawLine(spriteBatch,
                        Utility.VectorXY(CurrentVertices[v] + Origin),
                        Utility.VectorXY(CurrentVertices[v + 1] + Origin),
                        colour, strokeWeight);
            }
        }
        public void DrawWithLighting(SpriteBatch spriteBatch, Color colour, float strokeWeight = 3f)
        {
            if (CurrentVertices.Count > 0)
            {
                Vector2 averageVert = Utility.VectorXY(CurrentVertices[CurrentVertices.Count - 1] + CurrentVertices[0]) / 2f;
                Color lineColour = colour * CalculateLight(averageVert, UIManager.SunAngle, 3f);
                
                Drawing.DrawLine(spriteBatch,
                    Utility.VectorXY(CurrentVertices[CurrentVertices.Count - 1] + Origin),
                    Utility.VectorXY(CurrentVertices[0] + Origin),
                    lineColour, strokeWeight);

                for (int v = 0; v < CurrentVertices.Count - 1; v++)
                {
                    averageVert = Utility.VectorXY(CurrentVertices[v] + CurrentVertices[v + 1]) / 2f;
                    lineColour = colour * CalculateLight(averageVert, UIManager.SunAngle, 3f);

                    Drawing.DrawLine(spriteBatch,
                        Utility.VectorXY(CurrentVertices[v] + Origin),
                        Utility.VectorXY(CurrentVertices[v + 1] + Origin),
                        lineColour, strokeWeight);
                }
            }
        }
        public static void Draw(SpriteBatch spriteBatch, List<Vector2> vertices, Vector2 origin, Color colour, float strokeWeight = 3f)
        {
            if (vertices.Count > 0)
            {
                Drawing.DrawLine(spriteBatch, vertices[vertices.Count - 1] + origin, vertices[0] + origin, colour, strokeWeight);
                for (int v = 0; v < vertices.Count - 1; v++)
                    Drawing.DrawLine(spriteBatch, vertices[v] + origin, vertices[v + 1] + origin, colour, strokeWeight);
            }
        }
        
        public void ApplyTransforms()
        {
            Matrix translate = Matrix.CreateTranslation(Offset);
            Matrix scale = Matrix.CreateScale(ScaleX, ScaleY, ScaleZ);
            Matrix roll = Matrix.CreateRotationX(Roll);
            Matrix pitch = Matrix.CreateRotationY(Pitch);
            Matrix yaw = Matrix.CreateRotationZ(Yaw);

            for (int i = 0; i < OriginalVertices.Count; i++)
            {
                CurrentVertices[i] = Vector3.Transform(OriginalVertices[i], translate);
                CurrentVertices[i] = Vector3.Transform(CurrentVertices[i], scale);
                CurrentVertices[i] = Vector3.Transform(CurrentVertices[i], roll);
                CurrentVertices[i] = Vector3.Transform(CurrentVertices[i], pitch);
                CurrentVertices[i] = Vector3.Transform(CurrentVertices[i], yaw);
            }
        }
        public void ApplyTransforms(Polygon parent)
        {
            ApplyTransforms();

            Matrix roll = Matrix.CreateRotationX(parent.Roll);
            Matrix pitch = Matrix.CreateRotationY(parent.Pitch);
            Matrix yaw = Matrix.CreateRotationZ(parent.Yaw);

            for (int i = 0; i < OriginalVertices.Count; i++)
            {
                CurrentVertices[i] = Vector3.Transform(CurrentVertices[i], roll);
                CurrentVertices[i] = Vector3.Transform(CurrentVertices[i], pitch);
                CurrentVertices[i] = Vector3.Transform(CurrentVertices[i], yaw);
            }
        }
        public void Rotate(float angle, Axis axis)
        {
            switch (axis)
            {
                case Axis.X:
                    Roll += angle;
                    if (Roll > MathHelper.TwoPi)
                        Roll -= MathHelper.TwoPi;
                    break;
                case Axis.Y:
                    Pitch += angle;
                    if (Pitch > MathHelper.TwoPi)
                        Pitch -= MathHelper.TwoPi;
                    break;
                case Axis.Z:
                    Yaw += angle;
                    if (Yaw > MathHelper.TwoPi)
                        Yaw -= MathHelper.TwoPi;
                    break;
            }
        }
        public void Rotate(float roll, float pitch, float yaw)
        {
            Roll += roll;
            if (Roll > MathHelper.TwoPi)
                Roll -= MathHelper.TwoPi;

            Pitch += pitch;
            if (Pitch > MathHelper.TwoPi)
                Pitch -= MathHelper.TwoPi;

            Yaw += yaw;
            if (Yaw > MathHelper.TwoPi)
                Yaw -= MathHelper.TwoPi;
        }
        public void SetRotation(float angle, Axis axis)
        {
            switch (axis)
            {
                case Axis.X:
                    Roll = angle;
                    break;
                case Axis.Y:
                    Pitch = angle;
                    break;
                case Axis.Z:
                    Yaw = angle;
                    break;
            }
        }
        public void SetRotation(float roll, float pitch, float yaw)
        {
            Roll = roll;
            Pitch = pitch;
            Yaw = yaw;
        }

        public void Scale(float scale)
        {
            ScaleX *= scale;
            ScaleY *= scale;
            ScaleZ *= scale;
        }
        public void Scale(float scaleX, float scaleY)
        {
            ScaleX *= scaleX;
            ScaleY *= scaleY;
            ScaleZ *= 1f;
        }
        public void Scale(float scaleX, float scaleY, float scaleZ)
        {
            ScaleX *= scaleX;
            ScaleY *= scaleY;
            ScaleZ *= scaleZ;
        }
        public void SetScale(float scale)
        {
            ScaleX = scale;
            ScaleY = scale;
            ScaleZ = scale;
        }
        public void SetScale(float scaleX, float scaleY)
        {
            ScaleX = scaleX;
            ScaleY = scaleY;
            ScaleZ = 1f;
        }
        public void SetScale(float scaleX, float scaleY, float scaleZ)
        {
            ScaleX = scaleX;
            ScaleY = scaleY;
            ScaleZ = scaleZ;
        }

        public void Translate(float moveX, float moveY)
        {
            for (int i = 0; i < OriginalVertices.Count; i++)
                OriginalVertices[i] += new Vector3(moveX, moveY, 0);
        }
        public void Translate(List<Vector2> vertices, float moveX, float moveY)
        {
            for (int i = 0; i < vertices.Count; i++)
                vertices[i] += new Vector2(moveX, moveY);
        }

        public float CalculateLight(Vector2 vertice, float sunAngle, float sunStrength = 1f)
        {
            float angle = (float)Math.Atan2(vertice.Y, vertice.X);
            float difference = Math.Abs(MathHelper.WrapAngle(sunAngle - angle)) / MathHelper.TwoPi;
            return difference * sunStrength;
        }
        public float CalculateLight(Vector2 vertice, Vector2 lightPos, float sunStrength = 1f)
        {
            float angle = (float)Math.Atan2(vertice.Y, vertice.X);
            float lightAngle = (float)Math.Atan2(Origin.Y - lightPos.Y, Origin.X - lightPos.X);
            float difference = Math.Abs(MathHelper.WrapAngle(lightAngle - angle)) / MathHelper.TwoPi;
            return difference * sunStrength;
        }
        public float FindFurthestPoint()
        {
            float dist = 0;
            float length;
            foreach (Vector3 vertice in OriginalVertices)
            {
                length = vertice.Length();
                if (length > dist)
                    dist = length;
            }
            return dist;
        }
        public Rectangle GetBoundingBox()
        {
            if (CurrentVertices.Count <= 0)
                return new Rectangle((int)Origin.X, (int)Origin.Y, 0, 0);

            float minX = CurrentVertices[0].X + Origin.X;
            float maxX = CurrentVertices[0].X + Origin.X;
            float minY = CurrentVertices[0].Y + Origin.Y;
            float maxY = CurrentVertices[0].Y + Origin.Y;

            foreach (Vector3 vertice in CurrentVertices)
            {
                if (minX > vertice.X + Origin.X) minX = vertice.X + Origin.X;
                if (maxX < vertice.X + Origin.X) maxX = vertice.X + Origin.X;
                if (minY > vertice.Y + Origin.Y) minY = vertice.Y + Origin.Y;
                if (maxY < vertice.Y + Origin.Y) maxY = vertice.Y + Origin.Y;
            }

            return new Rectangle((int)minX, (int)minY, (int)(maxX - minX), (int)(maxY - minY));
        }
        public bool Intersects(Polygon polygon)
        {
            foreach (Vector3 vertice in polygon.CurrentVertices)
            {
                if (PointIntersects(Utility.VectorXY(vertice + polygon.Origin)))
                    return true;
            }

            return false;
        }
        public bool Intersects(Rectangle rectangle)
        {
            for (int y = 0; y < 2; y++)
                for (int x = 0; x < 2; x++)
                    if (PointIntersects(new Vector2(rectangle.Location.X + (rectangle.Width * x), rectangle.Location.Y + (rectangle.Height * y))))
                        return true;

            return false;
        }
        public bool PointIntersects(Vector2 testPoint)
        {
            //Check if a triangle or higher n-gon
            if (CurrentVertices.Count < 3)
                return false;

            //n>2 Keep track of cross product sign changes
            var pos = 0;
            var neg = 0;

            for (var i = 0; i < CurrentVertices.Count; i++)
            {
                //If point is in the polygon
                if (Utility.VectorXY(CurrentVertices[i] + Origin) == testPoint)
                    return true;

                //Form a segment between the i'th point
                var x1 = CurrentVertices[i].X + Origin.X;
                var y1 = CurrentVertices[i].Y + Origin.Y;

                //And the i+1'th, or if i is the last, with the first point
                var i2 = (i + 1) % CurrentVertices.Count;

                var x2 = CurrentVertices[i2].X + Origin.X;
                var y2 = CurrentVertices[i2].Y + Origin.Y;

                var x = testPoint.X;
                var y = testPoint.Y;

                //Compute the cross product
                var d = (x - x1) * (y2 - y1) - (y - y1) * (x2 - x1);

                if (d > 0) pos++;
                if (d < 0) neg++;

                //If the sign changes, then point is outside
                if (pos > 0 && neg > 0)
                    return false;
            }

            //If no change in direction, then on same side of all segments, and thus inside
            return true;
        }

        public void ResetVertices()
        {
            SetScale(1f);
            SetRotation(0f, 0f, 0f);
            CurrentVertices = OriginalVertices;
        }
        public Polygon Copy()
        {
            return new Polygon(Origin)
            {
                OriginalVertices = new List<Vector3>(OriginalVertices),
                CurrentVertices = new List<Vector3>(OriginalVertices),
                Origin = new Vector3(Origin.X, Origin.Y, Origin.Z),
                Pitch = Pitch,
                Yaw = Yaw,
                Roll = Roll
            };
        }
    }
}