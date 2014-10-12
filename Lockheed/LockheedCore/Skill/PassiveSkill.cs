

namespace TestSFML
{
    using System;
    public class PassiveSkill : Skill
    {
        public double Modifier { get; set; }
        public string Stat { get; set; }

          public PassiveSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost,String stat,double modifier)
            :base(name,reqStr,reqAgi,reqInt,tier,0)
        {
            this.Stat = stat;
            this.Modifier = modifier;
        }

          public override void Learn(this Character character,PassiveSkill skill)
          {
              base.Learn(character,skill);
            
              //character.Stats 
          }


    }
}
