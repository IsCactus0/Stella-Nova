using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Managers;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;
using System.Diagnostics;

namespace Stella_Nova.Classes.Objects
{
    public struct Circle
    {
        public Circle(float radius)
        {
            Position = Vector2.Zero;
            Radius = radius;
        }
        public Circle(float radius, float x, float y)
        {
            Position = new Vector2(x, y);
            Radius = radius;
        }

        public float Radius;
        public Vector2 Position;
        public float X
        {
            get { return Position.X; }
            set { Position.X = value; }
        }
        public float Y
        {
            get { return Position.Y; }
            set { Position.Y = value; }
        }
    }
    public class QuadTree
    {
        public QuadTree(Rectangle bounds)
        {
            Colour = Color.MediumPurple * 0.25f;
            Capacity = 32;
            Bounds = bounds;
            SpaceObjects = new List<SpaceObject>(Capacity);
            Divided = false;
        }
        public QuadTree(int capacity, Rectangle bounds)
        {
            Colour = Color.MediumPurple * 0.25f;
            Capacity = capacity;
            Bounds = bounds;
            SpaceObjects = new List<SpaceObject>(Capacity);
            Divided = false;
        }

        public int Capacity;
        public bool Divided;
        public Color Colour;
        public Rectangle Bounds;
        public QuadTree[] SubTrees;
        public List<SpaceObject> SpaceObjects;

        public void Add(SpaceObject spaceObject)
        {
            // If object is within bounds...
            if (spaceObject.Polygon.Rectangle.Intersects(Bounds))
            {
                if (Divided)
                    SubTrees[FindIndex(spaceObject.Position)].Add(spaceObject);
                else if (SpaceObjects.Count >= Capacity)
                {
                    if (Bounds.Height * Bounds.Width > 20)
                    {
                        Subdivide();
                        SubTrees[FindIndex(spaceObject.Position)].Add(spaceObject);
                    }
                    else SpaceObjects.Add(spaceObject);
                }
                else SpaceObjects.Add(spaceObject);
            }
        }
        public void Remove(SpaceObject spaceObject)
        {
            if (spaceObject.Polygon.Rectangle.Intersects(Bounds))
            {
                if (Divided)
                    SubTrees[FindIndex(spaceObject.Position)].Remove(spaceObject);
                else if (!SpaceObjects.Remove(spaceObject))
                    Debug.WriteLine($"Object: {spaceObject} does not exist in quadtree.");
            }
        }
        public void Subdivide()
        {
            // Create four sub trees...
            SubTrees = new QuadTree[4]
            {                
                new QuadTree(Capacity, new Rectangle(Bounds.X,                    Bounds.Y,                     Bounds.Width / 2, Bounds.Height / 2)), // Top Left (Index 0).                
                new QuadTree(Capacity, new Rectangle(Bounds.X + Bounds.Width / 2, Bounds.Y,                     Bounds.Width / 2, Bounds.Height / 2)), // Top Right (Index 1).                
                new QuadTree(Capacity, new Rectangle(Bounds.X,                    Bounds.Y + Bounds.Height / 2, Bounds.Width / 2, Bounds.Height / 2)), // Bottom Left (Index 2).                
                new QuadTree(Capacity, new Rectangle(Bounds.X + Bounds.Width / 2, Bounds.Y + Bounds.Height / 2, Bounds.Width / 2, Bounds.Height / 2))  // Bottom Right (Index 3).
            };

            // Move all objects down to leaves...
            for (int i = SpaceObjects.Count - 1; i >= 0; i--)
            {
                SubTrees[FindIndex(SpaceObjects[i].Position)].Add(SpaceObjects[i]);
                SpaceObjects.Remove(SpaceObjects[i]);
            }

            Divided = true;
        }
        public List<SpaceObject> Query(Rectangle bounds)
        {
            List<SpaceObject> found = new List<SpaceObject>();

            // Bounds dont overlap quad...
            if (!Bounds.Intersects(bounds))
                return found;
            
            // The bounds do overlap and the quad has subtrees...
            if (Divided)
                foreach (QuadTree subTree in SubTrees)
                    found.AddRange(subTree.Query(bounds));
            // This quad is a leaf and contains points to add...
            else
            {
                foreach (SpaceObject spaceObject in SpaceObjects)
                    if (bounds.Intersects(spaceObject.Polygon.Rectangle))
                        found.Add(spaceObject);
            }

            return found;
        }
        public bool QueryCollision(SpaceObject spaceObject)
        {
            if (spaceObject.Polygon.Rectangle.Intersects(Bounds))
            {
                if (Divided)
                    SubTrees[FindIndex(spaceObject.Position)].QueryCollision(spaceObject);
                else return SpaceObjects.Contains(spaceObject);
            }

            return false;
        }
        public int FindIndex(Vector2 searchPos)
        {
            Rectangle northWest = new Rectangle(Bounds.X,                    Bounds.Y,                     Bounds.Width / 2, Bounds.Height / 2);
            Rectangle northEast = new Rectangle(Bounds.X + Bounds.Width / 2, Bounds.Y,                     Bounds.Width / 2, Bounds.Height / 2);
            Rectangle southWest = new Rectangle(Bounds.X,                    Bounds.Y + Bounds.Height / 2, Bounds.Width / 2, Bounds.Height / 2);

            if (northWest.Contains(searchPos))
                return 0;
            else if (northEast.Contains(searchPos))
                return 1;
            else if (southWest.Contains(searchPos))
                return 2;
            else return 3;

            // int subWidth = Bounds.Width / 2;
            // int subHeight = Bounds.Height / 2;
            // 
            // // Round position down to nearest subdivision grid size...
            // Vector2 quadPosition = new Vector2(
            //     (float)(Math.Floor((float)(searchPos.X / subWidth)) * subWidth),
            //     (float)(Math.Floor((float)(searchPos.Y / subHeight)) * subHeight));
            // 
            // int subIndex;
            // 
            // // Along left side...
            // if (quadPosition.X == Bounds.X)
            // {
            //     if (quadPosition.Y == Bounds.Y)
            //         subIndex = 0; // ...and along top.
            //     else subIndex = 2; // ...and along bottom.
            // }
            // // Along right side...
            // else
            // {
            //     if (quadPosition.Y == Bounds.Y)
            //         subIndex = 1; // ...and along top.
            //     else subIndex = 3; // ...and along bottom.
            // }
            // 
            // return subIndex;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (!Divided)
            {
                Vector2 stringSize = UIManager.Roboto_Medium.MeasureString($"{SpaceObjects.Count}") * (Bounds.Width / 1028f) * 2f;

                spriteBatch.DrawString(
                    UIManager.Roboto_Medium, $"{SpaceObjects.Count}",
                    new Vector2(Bounds.X + Bounds.Width / 2f - (stringSize.X / 2f), Bounds.Y + Bounds.Height / 2f - (stringSize.Y / 2f)),
                    Colour, 0f, Vector2.Zero, (Bounds.Width / 1028f) * 2f, SpriteEffects.None, 0);
            }

            Drawing.DrawLine(spriteBatch,
                new Vector2(Bounds.X, Bounds.Y),
                new Vector2(Bounds.X, Bounds.Y + Bounds.Height), Colour, 5f);
            Drawing.DrawLine(spriteBatch,
                new Vector2(Bounds.X, Bounds.Y + Bounds.Height),
                new Vector2(Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height), Colour, 5f);
            Drawing.DrawLine(spriteBatch,
                new Vector2(Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height),
                new Vector2(Bounds.X + Bounds.Width, Bounds.Y), Colour, 5f);
            Drawing.DrawLine(spriteBatch,
                new Vector2(Bounds.X + Bounds.Width, Bounds.Y),
                new Vector2(Bounds.X, Bounds.Y), Colour, 5f);

            if (!(SubTrees is null))
                for (int i = 0; i < 4; i++)
                    SubTrees[i].Draw(spriteBatch);
        }
    }
}