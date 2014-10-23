using System;

namespace LockHeedCore
{

    public class NovaSkill : Skill
    {

        public int Speed { get; private set; }

        public NovaSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost,int speed)
            :base(name,reqStr,reqAgi,reqInt,tier,manaCost)
        {
            this.Speed = speed;
        }

        public override void Cast(Character character,float mouseX , float mouseY)
        {

            if (character.Stats.Mana >= this.ManaCost)
            {
                character.DecreaseMana(this.ManaCost);
      
            }
        }

    }
}
