using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharacterAndStats.Stat;

namespace CharacterAndStats.Characters
{
    public class Rogue : Character
    {
        private static readonly Stats initialRogueStats = new Stats(20, 100, 100, 100, 20);

        public Rogue(string id)
            : base(id, initialRogueStats)
        {
        }
    }
}
