using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharacterAndStats.Stat;

namespace CharacterAndStats.Characters
{
    public class Warrior : Character
    {
        private static readonly Stats initialWarriorStats = new Stats(20, 100, 100, 100, 20);

        public Warrior(string id) 
            : base(id, initialWarriorStats)
        {
        }
    }
}
