using System;
using SFML.Graphics;
namespace LockHeedCore
{
    public class DeadlyObstacle : Obstacle
    {
          public DeadlyObstacle( float x, float y)
              :base(new SpriteSheet(new Sprite(new Texture("level/obstacle/hole.png"))),x,y)
        {
            
        }



    }
}
