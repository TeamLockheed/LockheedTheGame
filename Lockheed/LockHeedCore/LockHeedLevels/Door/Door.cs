using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LockHeedCore
{
  
    public class Door 
    {
        public DoorPosition Position { get; private set; }
        public int LevelToId { get; private set; }
        public string SourceImage { get; private set; }

        public Door(DoorPosition position, int levelToId, string sourceImage)
        {
            this.Position = position;
            this.LevelToId = levelToId;
            this.SourceImage = sourceImage;
        }

        public float X
        {
            get
            {
                switch (this.Position)
                {
                    case DoorPosition.Top:
                    case DoorPosition.Bottom: return 300;
                    case DoorPosition.Left:
                    case DoorPosition.Right: return 0;
                    default: throw new InvalidEnumArgumentException("No such door type");
                }
            }
            set { this.X =  value; }
        }
        public float Y
        {
            get
            {
                switch (this.Position)
                {
                    case DoorPosition.Top: return -5;
                    case DoorPosition.Bottom: return 420;
                    case DoorPosition.Left:
                    case DoorPosition.Right: return 200;
                    default: throw new InvalidEnumArgumentException("No such door type");
                }
            }
            set { this.Y = value; }
        }

        public static DoorPosition getOppositePosition(DoorPosition doorPos)
        {
            switch (doorPos)
            {
                case DoorPosition.Bottom: return DoorPosition.Top;
                case DoorPosition.Top: return DoorPosition.Bottom;
                case DoorPosition.Left: return DoorPosition.Right;
                case DoorPosition.Right: return DoorPosition.Left;
                default: throw new InvalidEnumArgumentException("No such door type");
            }
        }

        public override string ToString()
        {
            return "Door: " + this.Position;
        }

    }
}
