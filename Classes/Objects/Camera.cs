using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stella_Nova.Classes.Objects
{
    public class Camera
    {
        public Camera(Viewport viewport)
        {
            this.viewport = viewport;
        }

        /// <summary>
        /// transforms the camera
        /// </summary>
        private Matrix transform;
        private Vector2 position;
        private Vector2 offset;
        private Viewport viewport;

        private float zoom = 1f;
        private float maxZoom = 0.1f;
        private float rotation = 0f;

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
            get { return viewport; }
        }
        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)(X - (viewport.Width / 2f) * (1f / Zoom)),
                    (int)(Y - (viewport.Height / 2f) * (1f / Zoom)),
                    (int)(viewport.Width * (1f / Zoom)),
                    (int)(viewport.Height * (1f / Zoom)));
            }
        }
        public Rectangle RenderBoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)((X - (viewport.Width / 2f) * (1f / Zoom)) - Main.RenderDistance),
                    (int)((Y - (viewport.Height / 2f) * (1f / Zoom)) - Main.RenderDistance),
                    (int)((viewport.Width * (1f / Zoom)) + Main.RenderDistance * 2f),
                    (int)((viewport.Height * (1f / Zoom)) + Main.RenderDistance * 2f));
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
        public float Zoom
        {
            get { return zoom; }
            set
            {
                zoom = value;
                if (zoom < maxZoom)
                    zoom = maxZoom;
            }
        }
        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public void Update(float delta, float strength, Vector2 target)
        {
            position = Vector2.Lerp(position, offset + target, delta * strength);
            transform =
                Matrix.CreateTranslation(new Vector3(-position.X, -position.Y, 0)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateScale(new Vector3(Zoom, Zoom, 0)) *
                Matrix.CreateTranslation(new Vector3(Viewport.Width / 2f, Viewport.Height / 2f, 0));
        }
    }
}