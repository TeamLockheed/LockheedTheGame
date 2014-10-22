using LockHeedCore.Exceptions;

namespace LockHeedCore
{
    using System;

    using SFML.Graphics;
    using SFML.Window;
    public abstract class Obstacle : IDrawable
    {
        public SpriteSheet SpriteSheet { get; set; }

        private float x;
        private float y;

        public Obstacle(SpriteSheet spriteSheet, float x, float y)
        {
            this.SpriteSheet = spriteSheet;
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return this.GetType() + " " + String.Format("X:{0}, Y{1}", this.X, this.Y);
        }

        public virtual void Draw(RenderTarget window)
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.X, this.Y);
            window.Draw(this.SpriteSheet.CurrentSprite);
        }

        public float X
        {
            get
            {
                return this.x;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(value, 0, "X cannot be negative!");
                this.x = value;
            }
        }

        public float Y
        {
            get
            {
                return this.y;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(value, 0, "Y cannot be negative!");
                this.y = value;
            }
        }
    }
}
