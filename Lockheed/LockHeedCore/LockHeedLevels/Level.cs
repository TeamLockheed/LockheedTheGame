using System;
using System.Collections.Generic;

namespace LockHeedCore
{

    public class Level
    {
        public int Id { get; set; }
        public string Background { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public List<Door> Doors { get; set; }

        public Level(int id,string background,List<Obstacle> obstacles=null,List<Door> doors=null)
        {
            this.Id = id;
            this.Background = background;
            this.Obstacles = obstacles ?? new List<Obstacle>();
            this.Doors = doors ?? new List<Door>(2);
        }
        public override string ToString()
        {
            return this.Id + "|" + String.Join(", ", this.Obstacles) + "|" + String.Join(", ", this.Doors);
        }

    }
}
