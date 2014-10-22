using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Graphics;

namespace LockHeedCore
{
    public class Rogue : Character
    {
        private static readonly Stats initialRogueStats = new Stats(17, 100, 12, 100, 12);
        private static readonly SpriteSheet rogueSpriteSheet = new SpriteSheet(new Sprite(new Texture("character/rogue/rogueFront.png")),
                                                                    new Sprite(new Texture("character/rogue/rogueFront.png")),
                                                                    new Sprite(new Texture("character/rogue/rogueBack.png")),
                                                                    new Sprite(new Texture("character/rogue/rogueLeft.png")),
                                                                    new Sprite(new Texture("character/rogue/rogueRight.png")));

        public Rogue(string id)
            : base(id, initialRogueStats,rogueSpriteSheet)
        {
        }
    }
}