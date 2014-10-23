using System;
using System.Collections.Generic;

using SFML.Graphics;

namespace LockHeedCore
{
    public interface IDrawable
    {

        SpriteSheet SpriteSheet { get; set; }
        void Draw(RenderTarget window);
    }
}
