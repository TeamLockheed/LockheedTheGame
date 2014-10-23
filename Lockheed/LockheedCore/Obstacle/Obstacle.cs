namespace LockHeedCore
{
    using LockHeedCore.Exceptions;
    using System;
    public abstract class Obstacle
    {
        private string sourceImage;
        private float x;
        private float y;

        public Obstacle(string sourceImage, float x, float y)
        {
            this.SourceImage = sourceImage;
            this.X = x;
            this.Y = y;
        }

        public string SourceImage
        {
            get
            {
                return this.sourceImage;
            }
            set
            {
                ExceptionsHolder.CheckNullableString(value, "SourceImage cannot be null or empty!");
                this.sourceImage = value;
            }
        }

        public float X
        {
            get
            {
                return this.x;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(value, 0, "X cannot be less than 0!");
                this.x = value;
            }
        }

        public float Y
        {
            get
            {
                return this.y;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(value, 0, "Y cannot be less than 0!");
                this.y = value;
            }
        }
    }
}
