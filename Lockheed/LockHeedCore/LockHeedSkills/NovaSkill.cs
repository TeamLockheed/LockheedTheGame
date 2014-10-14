using System;

namespace LockHeedCore
{

    public class NovaSkill : Skill
    {

        public int Radius { get; set; }

        public NovaSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost,int radius)
            :base(name,reqStr,reqAgi,reqInt,tier,manaCost)
        {
            this.Radius = radius;
        }

        public override void Cast(Character character,float mouseX, float mouseY)
        {
            if (character.Mana >= this.ManaCost)
            {
                character.Mana -= this.ManaCost;     
                Nova Nova = new Nova("test", this.Radius, character.X, character.Y);
            }
        }

    }
}
