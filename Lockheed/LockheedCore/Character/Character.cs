using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;
using SFML.Graphics;


namespace LockHeedCore
{

    public abstract class Character : ICollidable, IMoveable, IDrawable
    {
        public Stats Stats { get; set; }
         public string Id { get; set; }
        //----------Moveable--------------
        public float X {get; set;}
        public float Y { get;  set; }
        //----------Collidable------------
        public FloatRect BoundingBox { get; set; }
        //----------Drawable-------------
        public SpriteSheet SpriteSheet { get; set; }


        public List<Skill> UnlockedSkills { get; set; }
        public List<Tier> UnlockedTiers { get; set; }
       
       

         

        public Character(string id,Stats stats,SpriteSheet spriteSheet)
        {
            this.Id = id;
            this.Stats = stats;

            this.SpriteSheet = spriteSheet;
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(X, Y);

            this.BoundingBox = new FloatRect(X, Y + 50, 30, 30);
            this.X = 200;
            this.Y = 200;
        }
 
        
        public void Update()
        {

            if (Events.keyArrowDown)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.FrontSprite;
                if (this.BoundingBox.Top <= Program.HEIGHT - 80)
                {
                    this.Y += Program.MovementModifier;
                    
                }
            }
            if (Events.keyArrowUp)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.BackSprite;
                if (this.BoundingBox.Top >= 60)
                {
                    this.Y -= Program.MovementModifier;
                }
            }
            if (Events.keyArrowLeft)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.LeftSprite;
                if (this.BoundingBox.Left >= 60)
                {
                    this.X -= Program.MovementModifier;
                }

            }
            if (Events.keyArrowRight)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.RightSprite;
                if (this.BoundingBox.Left <= Program.WIDTH - 85)
                {
                    this.X += Program.MovementModifier;
                }
            }
            Move();
        }

        public void Move()
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(X, Y);
            this.BoundingBox = new FloatRect(X, Y + 50, 30, 30);
        }
        public void Draw(RenderTarget window)
        {
            window.Draw(this.SpriteSheet.CurrentSprite);
        }


        public virtual bool CheckCollision(ICollidable c1, ICollidable c2)
        {
            if (c1.BoundingBox.Intersects(c2.BoundingBox))
            { 
                return true; 
            }         
                return false;
        }

    }
}
