using System;
using System.Collections.Generic;
using SFML.Graphics;
namespace LockHeedCore
{
   public class ChestObstacle : Obstacle
    {
       public List<Item> Items { get; set; }
       public bool IsOpen { get; set; }

          public ChestObstacle( float x, float y,List<Item> items)
           : base(new SpriteSheet(new Sprite(new Texture("level/obstacle/chest.png"))), x, y)
       {
           this.Items = items ?? new List<Item>(4);
           this.IsOpen = false;
       }

       public void Open()
       {
           this.IsOpen = true;
           this.Items.Clear();
       }

    }
}
