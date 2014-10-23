using System;
using System.Collections.Generic;
using System.ComponentModel;
using SFML.Graphics;
using SFML.Window;
namespace LockHeedCore
{
  
    public class Door :IDrawable
    {
        private static readonly Random random = new Random();

        public DoorPosition Position { get; private set; }
        public int LevelToId { get; private set; }
        public bool IsOpen { get; set; }
        public SpriteSheet SpriteSheet { get; set; }

        private float x;
        private float y;

        public Door(DoorPosition position, int levelToId)
        {
            this.Position = position;
            this.LevelToId = levelToId;
            this.SpriteSheet = this.getSpriteSheet();
            this.IsOpen = false;
            this.x = this.getX();
            this.y = this.getY();
        }

        public float getX()
        {
            switch (this.Position)
            {
                case DoorPosition.Top:
                case DoorPosition.Bottom: return 320;
                case DoorPosition.Left: return -5;
                case DoorPosition.Right: return 740;
                default: throw new InvalidEnumArgumentException("No such door type");
            }
        }

        public float getY()
        {
            switch (this.Position)
            {
                case DoorPosition.Top: return -5;
                case DoorPosition.Bottom: return 395;
                case DoorPosition.Left:
                case DoorPosition.Right: return 150;
                default: throw new InvalidEnumArgumentException("No such door type");
            }
        }

      

        public static DoorPosition getOppositePosition(DoorPosition doorPos)
        {
            switch (doorPos)
            {
                case DoorPosition.Bottom: return DoorPosition.Top; 
                case DoorPosition.Top: return DoorPosition.Bottom;
                case DoorPosition.Left: return DoorPosition.Right;
                case DoorPosition.Right: return DoorPosition.Left;
                default: throw new InvalidEnumArgumentException("No such door type");
            }
        }

        public static DoorPosition getRandomPosition()
        {                 
            switch (random.Next(1, 5))
            {
                case 1: return DoorPosition.Bottom; 
                case 2: return DoorPosition.Left; 
                case 3: return DoorPosition.Right; 
                case 4: return DoorPosition.Top; 
                default: throw new InvalidEnumArgumentException("No such door type"); 
            }
        }

        private SpriteSheet getSpriteSheet()
        { 
         switch(this.Position)
                {
                    case DoorPosition.Top: return new SpriteSheet(new Sprite(new Texture("level/door/doorTop.png"))); 
                    case DoorPosition.Bottom: return new SpriteSheet(new Sprite(new Texture("level/door/doorBottom.png"))); 
                    case DoorPosition.Left: return new SpriteSheet(new Sprite(new Texture("level/door/doorLeft.png"))); 
                    case DoorPosition.Right: return new SpriteSheet(new Sprite(new Texture("level/door/doorRight.png"))); 
                    default: throw new InvalidEnumArgumentException("No such door type");
                }
        }

        public void Draw(RenderTarget window)
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.x, this.y);
            window.Draw(this.SpriteSheet.CurrentSprite);        
        }

        public override string ToString()
        {
            return "Door: " + this.Position;
        }

    }
}
