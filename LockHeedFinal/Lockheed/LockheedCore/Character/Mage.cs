using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Graphics;

namespace LockHeedCore
{
    public class Mage : Character
    {
        private static readonly Stats initialMageStats = new Stats(10, 100, 19, 100, 11);
        private static readonly SpriteSheet mageSpriteSheet = new SpriteSheet(new Sprite(new Texture("character/mage/mageFront.png")),
                                                                     new Sprite(new Texture("character/mage/mageFront.png")),
                                                                     new Sprite(new Texture("character/mage/mageBack.png")),
                                                                     new Sprite(new Texture("character/mage/mageLeft.png")),
                                                                     new Sprite(new Texture("character/mage/mageRight.png")));

        public Mage(string id)
            : base(id, initialMageStats,mageSpriteSheet)
        {
            
        }
    }
}