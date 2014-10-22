namespace LockHeedCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;

    using SFML.Window;
    using SFML.Graphics;

    using LockHeedCore.Exceptions;
    public abstract class Character : ICollidable, IMoveable, IDrawable
    {
        private Stats stats;
        private string id;
        //----------Moveable--------------
        private float x;
        private float y;
        //----------Collidable------------
        private FloatRect boundingBox;
        //----------Drawable-------------
        private SpriteSheet spriteSheet;
        private List<Skill> unloackedSkills;
        private List<Tier> unlockedTiers;

        public Character(string id, Stats stats, SpriteSheet spriteSheet)
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

        public Stats Stats
        {
            get
            {
                return this.stats;
            }
            set
            {
                this.Stats = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                ExceptionsHolder.CheckNullableString(value, "Id cannot be null or empty!");
                this.id = value;
            }
        }

        //----------Moveable--------------
        public float X
        {
            get
            {
                return this.x;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(value, 0, "X cannot be less than 0!");
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
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(value, 0, "Y cannot be less than 0!");
                this.y = value;
            }
        }

        //----------Collidable------------
        public FloatRect BoundingBox
        {
            get
            {
                return this.boundingBox;
            }
            set
            {
                this.boundingBox = value;
            }
        }

        //----------Drawable-------------
        public SpriteSheet SpriteSheet
        {
            get
            {
                return this.spriteSheet;
            }
            set
            {
                this.spriteSheet = value;
            }
        }

        public List<Skill> UnlockedSkills
        {
            get
            {
                return this.unloackedSkills;
            }
            set
            {
                this.unloackedSkills = value;
            }
        }

        public List<Tier> UnlockedTiers
        {
            get
            {
                return this.unlockedTiers;
            }
            set
            {
                this.unlockedTiers = value;
            }
        }
    }
}
