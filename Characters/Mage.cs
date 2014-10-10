using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharacterAndStats.Stat;

namespace CharacterAndStats.Characters
{
    public class Mage : Character
    {
        private static readonly Stats initialMageStats = new Stats(20, 100, 100, 100, 20);

        public Mage(string id) 
            : base(id, initialMageStats)
        {
        }
    }
}
