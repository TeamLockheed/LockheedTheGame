namespace LockHeedCore
{
    using System;

    using LockHeedCore.Exceptions;

    public abstract class Effect
    {
        private string directory;
        private double x;
        private double y;

        public Effect(string directory, double x, double y)
        {
            this.Directory = directory;
            this.X = x;
            this.Y = y;
        }

        public string Directory
        {
            get
            {
                return this.directory;
            }
            set
            {
                ExceptionsHolder.CheckNullableString(value, "Directory cannot be null or empty!");
                this.directory = value;
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 0, "X cannot be less than 0!");
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 0, "Y cannot be less than 0!");
                this.y = value;
            }
        }
    }
}
