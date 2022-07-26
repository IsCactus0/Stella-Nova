using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects
{
    public class KinematicArm
    {
        public KinematicArm()
        {
            Origin = Vector2.Zero;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < 5; i++)
                Joints.Add(new KinematicJoint(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 1f, 1f));
            SegmentLength = 32;
            SegmentThickness = 10;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(Vector2 origin)
        {
            Origin = origin;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < 5; i++)
                Joints.Add(new KinematicJoint(Origin.X, Origin.Y));
            SegmentLength = 32;
            SegmentThickness = 10;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(Vector2 origin, int segmentCount)
        {
            Origin = origin;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint(Origin.X, Origin.Y));
            SegmentLength = 32;
            SegmentThickness = 10;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(Vector2 origin, int segmentCount, float segmentLength)
        {
            Origin = origin;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint(Origin.X, Origin.Y));
            SegmentLength = segmentLength;
            SegmentThickness = 10;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(Vector2 origin, int segmentCount, float segmentLength, float segmentThickness)
        {
            Origin = origin;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint(Origin.X, Origin.Y));
            SegmentLength = segmentLength;
            SegmentThickness = segmentThickness;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(Vector2 origin, int segmentCount, float segmentLength, float segmentThickness, bool allowShrinking)
        {
            Origin = origin;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint(Origin.X, Origin.Y));
            SegmentLength = segmentLength;
            SegmentThickness = segmentThickness;
            AllowShrinking = allowShrinking;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(Vector2 origin, int segmentCount, float segmentLength, float segmentThickness, bool allowShrinking, Color colour)
        {
            Origin = origin;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint(Origin.X, Origin.Y));
            SegmentLength = segmentLength;
            SegmentThickness = segmentThickness;
            AllowShrinking = allowShrinking;
            BaseColour = colour;
            TipColour = BaseColour;
        }
        public KinematicArm(Vector2 origin, int segmentCount, float segmentLength, float segmentThickness, bool allowShrinking, Color baseColour, Color tipColour)
        {
            Origin = origin;
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint(Origin.X, Origin.Y));
            SegmentLength = segmentLength;
            SegmentThickness = segmentThickness;
            AllowShrinking = allowShrinking;
            BaseColour = baseColour;
            TipColour = tipColour;
        }

        public float SegmentLength;
        public float SegmentThickness;
        public bool AllowShrinking;
        public Color BaseColour;
        public Color TipColour;
        public Vector2 Origin;
        public List<KinematicJoint> Joints;

        public virtual void Update(float delta)
        {
            if (Joints.Count > 0)
                Joints[0].Position = Origin;

            if (Joints.Count < 2)
                return;

            for (int i = 1; i < Joints.Count; i++)
            {
                Vector2 toParent = Joints[i - 1].Position - Joints[i].Position;
                float distance = toParent.Length();

                if (distance == 0 || (AllowShrinking && distance < SegmentLength))
                    continue;

                float error = distance - SegmentLength;
                toParent /= distance;
                toParent *= error;
                Joints[i].Position += toParent;
                Joints[i].Update(delta);
            }
        }
        public virtual void Draw(SpriteBatch spritebatch)
        {
            for (int i = 1; i < Joints.Count; i++)
            {
                float thickness = Utility.Map(i, 0, Joints.Count - 1, SegmentThickness, 1);
                Color colour = Color.Lerp(BaseColour, TipColour, (float)i / Joints.Count);
                Drawing.DrawLine(spritebatch, Joints[i - 1].Position, Joints[i].Position, colour, thickness);
            }
        }
    }
}