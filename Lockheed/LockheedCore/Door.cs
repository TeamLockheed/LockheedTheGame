namespace LockHeedCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Door
    {
        private DoorPosition position;
        private string pathTo;
        private string sourceImage;
        
        public Door(DoorPosition position, string pathTo, string sourceImage)
        {
            this.Position = position;
            this.PathTo = pathTo;
            this.SourceImage = sourceImage;
        }
        
        public float X
        {
            get
            {
                if (this.Position == DoorPosition.Top)
                {
                    return 300;
                }
                else
                {
                    return 200;
                }
            }
            set { this.X = value; }
        }
        
        public float Y
        {
            get
            {
                if (this.Position == DoorPosition.Top)
                {
                    return -5;
                }
                else
                {
                    return 200;
                }
            }
            set { this.Y = value; }
        }

        public DoorPosition Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public string PathTo
        {
            get
            {
                return this.pathTo;
            }
            set
            {
                this.CheckNullableString(value, "Wrong path!");
                this.pathTo = value;
            }
        }

        public string SourceImage
        {
            get
            {
                return this.sourceImage;
            }
            set
            {
                this.CheckNullableString(value, "Wrong Image Source!");
                this.sourceImage = value;
            }
        }

        private void CheckNullableString(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
