using System;
using SFML.Graphics;
using SFML.Window;
namespace LockHeedCore
{
    public abstract class Obstacle :IDrawable , ICollidable
    {
        public SpriteSheet SpriteSheet { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public FloatRect BoundingBox { get; set; }

        public Obstacle(SpriteSheet spriteSheet, float x, float y)
        {
            this.SpriteSheet = spriteSheet;
            this.X = x;
            this.Y = y;
            this.BoundingBox = new FloatRect(X+5, Y, 40, 40);
        }

        public override string ToString()
        { 
           return this.GetType() + " " + String.Format("X:{0}, Y{1}",this.X,this.Y);
        }

        public virtual void Draw(RenderTarget window)
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.X, this.Y);
            window.Draw(this.SpriteSheet.CurrentSprite);
        }

    }
}
