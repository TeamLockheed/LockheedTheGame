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
    }
}
