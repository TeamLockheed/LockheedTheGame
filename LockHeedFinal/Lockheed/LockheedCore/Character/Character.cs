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

        public Skill CurrentSkill { get; set; }

        public bool IsDead { get; set; }

        public Character(string id,Stats stats,SpriteSheet spriteSheet)
        {
            this.Id = id;
            this.Stats = stats;

            this.SpriteSheet = spriteSheet;
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(X, Y);

            this.BoundingBox = new FloatRect(X, Y + 50, 30, 30);
            
            this.X = 100;
            this.Y = 100;
            this.IsDead = false;

        }
       
      
        public void Update()
        {

            if (Events.keyArrowDown)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.FrontSprite;
                if (this.BoundingBox.Top <= Program.HEIGHT - 85)
                {
                    FloatRect rect = new FloatRect(X + 10, Y + 60 + Program.MovementModifier, BoundingBox.Width, BoundingBox.Height);
                    if (!CheckCollision(rect)) { 
                    this.Y += Program.MovementModifier;
                    }
                    
                }
            }
            if (Events.keyArrowUp)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.BackSprite;
                if (this.BoundingBox.Top >= 55)
                {

                    FloatRect rect = new FloatRect(X + 10, Y + 60 - Program.MovementModifier, BoundingBox.Width, BoundingBox.Height);
                    if (!CheckCollision(rect))
                    {
                        this.Y -= Program.MovementModifier;
                    }
                }
            }
            if (Events.keyArrowLeft)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.LeftSprite;
                if (this.BoundingBox.Left >= 55)
                {
                    FloatRect rect = new FloatRect(X - Program.MovementModifier + 10, Y + 60, BoundingBox.Width, BoundingBox.Height);
                    if (!CheckCollision(rect))
                    {
                        this.X -= Program.MovementModifier;
                    }
                }

            }
            if (Events.keyArrowRight)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.RightSprite;
       
                if (this.BoundingBox.Left <= Program.WIDTH - 100)
                {
                    FloatRect rect = new FloatRect(X + 10 + Program.MovementModifier, Y + 60, BoundingBox.Width, BoundingBox.Height);
                    if (!CheckCollision(rect))
                    {
                        this.X += Program.MovementModifier;
                    }
                }
            }
   
        }

        public void Move()
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(X, Y);
            this.BoundingBox = new FloatRect(X + 10, Y + 60, 40, 40);
        }

        public void Draw(RenderTarget window)
        {
            window.Draw(this.SpriteSheet.CurrentSprite);
        }


        public bool CheckCollision(FloatRect tempRect)
        {
            foreach (var obstacle in EntityManager.CurrentLevel.Obstacles)
            {
                if (obstacle.BoundingBox.Intersects(tempRect))
                {
                    return true;
                }
            
            }
                return false;
        }


        public void DecreaseMana(int value)
        {
            this.Stats = new Stats(this.Stats.Agility, this.Stats.Health, this.Stats.Intelect, this.Stats.Mana - value, this.Stats.Strength);
        }
        public void DecreaseHP(int value)
        {
            this.Stats = new Stats(this.Stats.Agility, this.Stats.Health - value, this.Stats.Intelect, this.Stats.Mana, this.Stats.Strength);
        }


    }
}
