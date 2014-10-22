using System;
using System.Collections.Generic;

namespace LockHeedCore
{  
    public class Nova : Effect
    {

        private int currentRadius = 0;
        private const int radius = 300;
        public int Speed { get; private set; }
        public static List<Nova> novas = new List<Nova>();


        public Nova(string directory, double X, double Y, int speed)
            : base(directory, X, Y)
        {
            novas.Add(this);
        }

        public void MoveNova() 
        {
            if (this.currentRadius >= radius)
            {
                novas.Remove(this);
            }
            else
            {
                this.currentRadius += this.Speed;
            }
        }

        
    }
}
