using System;
using System.Collections.Generic;

namespace LockHeedCore
{
   public class ChestObstacle : Obstacle
    {
       public List<Item> Items { get; set; }
       public bool IsOpen { get; set; }

       public ChestObstacle(string sourceImage,float x,float y,List<Item> items=null)
           :base(sourceImage,x,y)
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
