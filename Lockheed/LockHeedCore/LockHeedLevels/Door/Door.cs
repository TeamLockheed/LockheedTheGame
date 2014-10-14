using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockHeedCore
{
  
    public class Door
    {
        public DoorPosition Position { get; set; }
        public string PathTo { get; set; }
        public string SourceImage { get; set; }

        public Door(DoorPosition position,string pathTo,string sourceImage)
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
    }
}
