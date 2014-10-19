using System;

namespace LockHeedCore
{
    
    public class ProjectileSkill : Skill
    {

        public int ProjectileSpeed { get; private set; } 
        public ProjectileSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost,int speed)
            :base(name,reqStr,reqAgi,reqInt,tier,manaCost)
        {
            this.ProjectileSpeed = speed;
        }

        public override void Cast(Character character,float mouseX,float mouseY)
        {
            if (character.Mana >= this.ManaCost) 
            {
                character.Mana -= this.ManaCost;

                var rad = Math.Atan2(character.Y-mouseY, character.X - mouseX);
                var deltaX = Math.Cos(rad);
                var deltaY = Math.Sin(rad);

                Projectile Projectile = new Projectile("testDirectory", character.X, character.Y, deltaX, deltaY,ProjectileSpeed);
            }     
        }

    }
}
