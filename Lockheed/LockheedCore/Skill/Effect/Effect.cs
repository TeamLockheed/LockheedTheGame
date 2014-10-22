using System;

namespace LockHeedCore
{
    public abstract class Effect
    {

        public string Directory;
        public double X;
        public double Y;

        public Effect(string directory, double x, double y) 
        {
            this.Directory = directory;
            this.X = x;
            this.Y = y;
        }
        
    }
}
