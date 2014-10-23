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
                var rad = Math.Atan2(character.SpriteSheet.CurrentSprite.Position.Y - mouseY, character.SpriteSheet.CurrentSprite.Position.X - mouseX);
                var deltaX = Math.Cos(rad);
                var deltaY = Math.Sin(rad);
                Projectile Projectile = new Projectile("testDirectory", character.SpriteSheet.CurrentSprite.Position.X, character.SpriteSheet.CurrentSprite.Position.Y, deltaX, deltaY, ProjectileSpeed);
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
