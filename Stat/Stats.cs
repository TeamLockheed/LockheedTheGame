using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterAndStats.Stat
{
    public struct Stats
    {

        private int agility;
        private int health;
        private int intelect;
        private int mana;
        private int strenght;

        public int Agility
        {
            get
            {
                return this.agility;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Agility cannot be negative.");
                }
                this.agility = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative.");
                }
                this.health = value;
            }
        }

        public int Intelect
        {
            get
            {
                return this.intelect;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Intelect cannot be negative.");
                }
                this.intelect = value;
            }
        }

        public int Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Mana cannot be negative.");
                }
                this.mana = value;
            }
        }

        public int Strength
        {
            get
            {
                return this.strenght;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Strenght cannot be negative.");
                }
                this.strenght = value;
            }
        }

        public Stats(int agility, int health, int intelect, int mana, int strenght) : this ()
        {
            this.Agility = agility;
            this.Health = health;
            this.Intelect = intelect;
            this.Mana = mana;
            this.Strength = strenght;
        }
        
    }
}
