using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LockHeedCore
{
    public struct Stats
    {

        private int agility;
        private int health;
        private int intelect;
        private int mana;
        private int strength;

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
                return this.strength;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Strength cannot be negative.");
                }
                this.strength = value;
            }
        }

        public Stats(int agility, int health, int intelect, int mana, int strength)
            : this()
        {
            this.Agility = agility;
            this.Health = health;
            this.Intelect = intelect;
            this.Mana = mana;
            this.Strength = strength;
        }

        public void DecreaseMana(int value)
        {
            this.Mana -= value;
        }
    }
}