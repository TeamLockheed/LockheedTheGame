using System;

namespace LockHeedCore
{
    
    public abstract class Skill : ILearnable , ICastable
    {
        private string name;
        private int requiredStrength;
        private int requiredAgility;
        private int requiredIntelligence;
        private Tier tier;
        private int manaCost;

        public Skill(string name,int reqStr,int reqAgi,int reqInt,Tier tier, int manaCost)
        {
            this.Name = name;
            this.RequiredStrength = reqStr;
            this.RequiredAgility = reqAgi;
            this.RequiredIntelligence = reqInt;
            this.Tier = tier;
            this.ManaCost = manaCost;
        }

        public string Name 
        {
            get {  return this.name;  }
            set
            {
                if (String.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentNullException("Skill name can not be null or empty");
                }
                this.name = value;
            }   
        }

        public int RequiredStrength 
        {
            get { return this.requiredStrength; }
            set 
            {
                if (value <= 9) 
                {
                    throw new ArgumentException("Required strength must be a number larger than 9");
                }
                this.requiredStrength = value;
            }
        }

        public int RequiredAgility
        {
            get { return this.requiredAgility; }
            set
            {
                if (value <= 9)
                {
                    throw new ArgumentException("Required agility must be a number larger than 9");
                }
                this.requiredAgility = value;
            }
        }

        public int RequiredIntelligence
        {
            get { return this.requiredIntelligence; }
            set
            {
                if (value <= 9)
                {
                    throw new ArgumentException("Required intelligence must be a number larger than 9");
                }
                this.requiredIntelligence = value;
            }
        }

        public Tier Tier
        {
            get { return this.tier; }
            set { this.tier = value; }
        }

        public int ManaCost 
        {
            get { return this.manaCost; }
            set { this.manaCost = value; }
        }

        public abstract void Cast(Character character,float x,float y);

        public virtual void Learn(Character character)
        {
            if (character.UnlockedTiers.Contains(this.Tier) && !character.UnlockedSkills.Contains(this))
            {
                character.UnlockedSkills.Add(this);
            }

        }



    }
}
