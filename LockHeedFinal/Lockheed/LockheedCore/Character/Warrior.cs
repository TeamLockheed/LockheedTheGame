using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Graphics;

namespace LockHeedCore
{
    public class Warrior : Character
    {
        private static readonly Stats initialWarriorStats = new Stats(10, 100, 10, 100, 18);
        private static readonly SpriteSheet warriorSpriteSheet = new SpriteSheet(new Sprite(new Texture("character/warrior/warriorFront.png")),
                                                            new Sprite(new Texture("character/warrior/warriorFront.png")),
                                                            new Sprite(new Texture("character/warrior/warriorBack.png")),
                                                            new Sprite(new Texture("character/warrior/warriorLeft.png")),
                                                            new Sprite(new Texture("character/warrior/warriorRight.png")));

        public Warrior(string id)
            : base(id, initialWarriorStats,warriorSpriteSheet)
        {
        }
    }
}