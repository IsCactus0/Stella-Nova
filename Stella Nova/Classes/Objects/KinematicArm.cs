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
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < 5; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = 32;
            StartThickness = 10;
            EndThickness = 1;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(int segmentCount)
        {
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = 32;
            StartThickness = 10;
            EndThickness = 1;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(int segmentCount, float segmentLength)
        {
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = segmentLength;
            StartThickness = 10;
            EndThickness = 1;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(int segmentCount, float segmentLength, float thickness)
        {
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = segmentLength;
            StartThickness = thickness;
            EndThickness = 1;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(int segmentCount, float segmentLength, float startThickness, float endThickness)
        {
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = segmentLength;
            StartThickness = startThickness;
            EndThickness = endThickness;
            AllowShrinking = true;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(int segmentCount, float segmentLength, float startThickness, float endThickness, bool allowShrinking)
        {
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = segmentLength;
            StartThickness = startThickness;
            EndThickness = endThickness;
            AllowShrinking = allowShrinking;
            BaseColour = Color.White;
            TipColour = BaseColour;
        }
        public KinematicArm(int segmentCount, float segmentLength, float startThickness, float endThickness, bool allowShrinking, Color colour)
        {
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = segmentLength;
            StartThickness = startThickness;
            EndThickness = endThickness;
            AllowShrinking = allowShrinking;
            BaseColour = colour;
            TipColour = BaseColour;
        }
        public KinematicArm(int segmentCount, float segmentLength, float startThickness, float endThickness, bool allowShrinking, Color baseColour, Color tipColour)
        {
            Joints = new List<KinematicJoint>();
            for (int i = 0; i < segmentCount; i++)
                Joints.Add(new KinematicJoint());
            SegmentLength = segmentLength;
            StartThickness = startThickness;
            EndThickness = endThickness;
            AllowShrinking = allowShrinking;
            BaseColour = baseColour;
            TipColour = tipColour;
        }

        public float SegmentLength;
        public float StartThickness;
        public float EndThickness;
        public bool AllowShrinking;
        public Color BaseColour;
        public Color TipColour;
        public List<KinematicJoint> Joints;

        public virtual void Follow(Vector2 target, float delta = 0f)
        {
            Vector2 toParent = target - Joints[0].Position;
            float distance = 1;
            if (target != Joints[0].Position)
                distance = toParent.Length();
            if (Joints.Count > 0)
                Joints[0].Position += toParent / distance * delta * 500f;

            if (Joints.Count < 2)
                return;

            for (int i = 1; i < Joints.Count; i++)
            {
                toParent = Joints[i - 1].Position - Joints[i].Position;
                distance = toParent.Length();

                if (distance == 0 || (AllowShrinking && distance <= SegmentLength))
                    continue;

                float error = distance - SegmentLength;
                toParent /= distance;

                toParent *= error;
                Joints[i].Position += toParent;
            }
        }
        public virtual void Limit(Vector2 origin)
        {
            if (Joints.Count > 0)
                Joints[Joints.Count - 1].Position = origin;

            for (int i = Joints.Count - 2; i >= 0; i--)
            {
                Vector2 toChild = Joints[i + 1].Position - Joints[i].Position;
                float distance = toChild.Length();

                if (distance == 0 || (AllowShrinking && distance <= SegmentLength))
                    continue;

                float error = distance - SegmentLength;
                toChild /= distance;
                toChild *= error;
                Joints[i].Position += toChild;
            }
        }
        public virtual void Draw(SpriteBatch spritebatch)
        {
            for (int i = 1; i < Joints.Count; i++)
            {
                float thickness = Utility.Map(i, 0, Joints.Count - 1, StartThickness, EndThickness);
                Color colour = Color.Lerp(BaseColour, TipColour, (float)i / Joints.Count);
                Drawing.DrawLine(spritebatch, Joints[i - 1].Position, Joints[i].Position, colour, thickness);
            }
        }
    }
}