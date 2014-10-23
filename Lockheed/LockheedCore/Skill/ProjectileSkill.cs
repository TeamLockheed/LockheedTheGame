namespace LockHeedCore
{
    using System;
    using LockHeedCore.Exceptions;

    public class ProjectileSkill : Skill
    {
        private int projectileSpeed;

        public ProjectileSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost, int speed)
            : base(name, reqStr, reqAgi, reqInt, tier, manaCost)
        {
            this.ProjectileSpeed = speed;
        }

        public override void Cast(Character character, float mouseX, float mouseY)
        {
            if (character.Stats.Mana >= this.ManaCost)
            {
                character.Stats.DecreaseMana(this.ManaCost);
                
                var rad = Math.Atan2(mouseY - (character.BoundingBox.Top), mouseX - (character.BoundingBox.Left));
                var deltaX = (float)Math.Cos(rad);
                var deltaY = (float)Math.Sin(rad);
                Sprite projSprite = new Sprite(new Texture(this.Directory));
                projSprite.Rotation = (float)(rad*180/Math.PI);
                Projectile Projectile = new Projectile(new SpriteSheet(projSprite), character.BoundingBox.Left, character.BoundingBox.Top-10, deltaX, deltaY, Program.MovementModifier);
            }
        }

        public int ProjectileSpeed
        {
            get
            {
                return this.projectileSpeed;
            }
            private set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 1, "ProjectileSpeed cannot be 0 or negative!");
                this.projectileSpeed = value;
            }
        }
    }
}
