using System;

namespace LockHeedCore
{
    public abstract class Obstacle 
    {
        public string SourceImage { get; set; }
        public float X { get; set; }
        public float Y { get; set; }


        public Obstacle(string sourceImage,float x, float y)
        {
            this.SourceImage = sourceImage;
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        { 
        return this.GetType() + " " + String.Format("X:{0}, Y{1}",this.X,this.Y);
        }

    }
}
