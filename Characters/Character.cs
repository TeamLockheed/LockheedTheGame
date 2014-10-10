using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharacterAndStats.Stat;

namespace CharacterAndStats.Characters
{
    public abstract class Character
    {
        private Stats stats;
        private string id;


        public Stats Stats
        {
            get
            {
                return this.stats;
            }
            set
            {
                this.stats = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Character must have identifier.");
                }
                this.id = value;
            }
        }

        protected Character(string id, Stats stats)
        {
            this.Stats = stats;
            this.Id = id;
        }
    }
}
