﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects
{
    public class Camera
    {
        public Camera()
        {

        }
        public Camera(Viewport viewport)
        {
            this.viewport = viewport;
        }

        private Matrix transform;
        private Vector2 position;
        private Vector2 offset;
        private Viewport viewport;

        private float scale = 1f;
        private float maxScale = 0.1f;
        private float rotation = 0f;
        private float aspectRatio = 1f;

        public Matrix Transform
        {
            get { return transform; }
        }
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        public Vector2 Offset
        {
            get { return offset; }
            set { offset = value; }
        }
        public Viewport Viewport
        {
            set { viewport = value; }
            get { return viewport; }
        }
        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)(X - (viewport.Width / 2f) * (1f / Scale)),
                    (int)(Y - (viewport.Height / 2f) * (1f / Scale)),
                    (int)(viewport.Width * (1f / Scale)),
                    (int)(viewport.Height * (1f / Scale)));
            }
        }
        public Rectangle RenderBoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)((X - (viewport.Width / 2f) * (1f / Scale)) - Main.RenderDistance),
                    (int)((Y - (viewport.Height / 2f) * (1f / Scale)) - Main.RenderDistance),
                    (int)((viewport.Width * (1f / Scale)) + Main.RenderDistance * 2f),
                    (int)((viewport.Height * (1f / Scale)) + Main.RenderDistance * 2f));
            }
        }
        public float X
        {
            get { return position.X; }
            set { position.X = value; }
        }
        public float Y
        {
            get { return position.Y; }
            set { position.Y = value; }
        }
        public float OffX
        {
            get { return offset.X; }
            set { offset.X = value; }
        }
        public float OffY
        {
            get { return offset.Y; }
            set { offset.Y = value; }
        }
        public float Scale
        {
            get { return scale; }
            set
            {
                scale = value;
                if (scale < maxScale)
                    scale = maxScale;
            }
        }
        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }
        public float AspectRatio
        {
            get { return aspectRatio; }
            set { aspectRatio = value; }
        }

        public void Update(float delta, float strength, Vector2 target)
        {
            position = Vector2.Lerp(position, offset + target, delta * strength);
            transform =
                Matrix.CreateTranslation(new Vector3(-position.X, -position.Y, 0)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateScale(new Vector3(Scale, Scale, 0)) *
                Matrix.CreateTranslation(new Vector3(Viewport.Width / 2f, Viewport.Height / 2f, 0));
        }
    }
}