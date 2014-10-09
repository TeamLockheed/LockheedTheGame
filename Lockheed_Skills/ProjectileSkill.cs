

namespace TestSFML
{
    using System;
    public class ProjectileSkill : Skill
    {
        public int Distance { get; set; }

        public ProjectileSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost,int distance)
            :base(name,reqStr,reqAgi,reqInt,tier,manaCost)
        {
            this.Distance = distance;
        }

        public override void Cast(this Character character,ProjectileSkill projSkill,int mouseX,int mouseY)
        {
            if (character.Mana >= projSkill.ManaCost) 
            {
                character.Mana -= projSkill.ManaCost;

                var rad = Math.Atan2(character.Y-mouseY, character.X - mouseX);
                var deltaX = Math.Cos(rad);
                var deltaY = Math.Sin(rad);

                Projectile Projectile = new Projectile("test", projSkill.Distance, character.X, character.Y, deltaX, deltaY);
            }     
        }

    }
}
