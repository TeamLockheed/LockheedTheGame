using System;
using SFML.Graphics;
namespace LockHeedCore
{
    public abstract class Effect : ICollidable, IMoveable , IDrawable
    {

        public string Directory;
        public float X { get; set; }
        public float Y { get; set; }

        public FloatRect BoundingBox { get; set; }

        public SpriteSheet SpriteSheet { get; set; }

    
        public abstract void Move();

        public Effect(SpriteSheet spriteSheet, float x, float y) 
        {
            this.SpriteSheet = spriteSheet;
            this.X = x;
            this.Y = y;
        }
        public virtual void Draw(RenderTarget window)
        {
            window.Draw(this.SpriteSheet.CurrentSprite);
        }
    }
}
