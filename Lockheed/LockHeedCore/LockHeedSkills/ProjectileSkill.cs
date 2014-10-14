using System;

namespace LockHeedCore
{
    
    public class ProjectileSkill : Skill
    {
        public int Distance { get; set; }

        public ProjectileSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost,int distance)
            :base(name,reqStr,reqAgi,reqInt,tier,manaCost)
        {
            this.Distance = distance;
        }

        public override void Cast(Character character,float mouseX,float mouseY)
        {
            if (character.Mana >= this.ManaCost) 
            {
                character.Mana -= this.ManaCost;

                var rad = Math.Atan2(character.Y-mouseY, character.X - mouseX);
                var deltaX = Math.Cos(rad);
                var deltaY = Math.Sin(rad);

                Projectile Projectile = new Projectile("test", 500, character.X, character.Y, deltaX, deltaY);
            }     
        }

    }
}
