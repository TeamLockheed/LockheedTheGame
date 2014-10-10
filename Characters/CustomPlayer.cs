using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharacterAndStats.Stat;

namespace CharacterAndStats.Characters
{
    public class CustomPlayer : Character
    {
        private static readonly Stats initialCustomStats = new Stats(100, 100, 100, 100, 100);

        public CustomPlayer(string id)
            : base(id, initialCustomStats)
        {
        }
    }
}
