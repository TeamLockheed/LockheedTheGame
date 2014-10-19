using System;
using System.Collections.Generic;

namespace LockHeedCore
{
   public class Arc : Effect
    {
       public string Directory { get; set; }
       public double Distance { get; set; }
       public float X { get; set; }
       public float Y { get; set; }
       public float DeltaX { get; set; }
       public float DeltaY { get; set; }

       public List<Projectile> projectilesInArc {get;set;}

       public static List<Arc> arcs = new List<Arc>();

        public Arc(string directory, float x, float y, float deltaX, float deltaY)
            : base(directory, x, y)
        {
            this.DeltaX = deltaX;
            this.DeltaY = deltaY;          
        }

        public void MoveArc()
        {
            this.X += this.DeltaX * Program.MovementModifier;
            this.Y += this.DeltaY * Program.MovementModifier;
            this.Distance -= Math.Sqrt(Math.Pow(this.DeltaX * Program.MovementModifier, 2) + Math.Pow(this.DeltaY * Program.MovementModifier, 2));

            if (CheckCollision(this) || this.Distance <= 0)
            {
                arcs.Remove(this);
            }
        }

        public bool CheckCollision(Arc arc)
        {
            throw new NotImplementedException("Under construction");

        }

    }
}
