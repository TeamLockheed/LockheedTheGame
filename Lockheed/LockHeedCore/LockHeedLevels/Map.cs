using System;
using System.Collections.Generic;


namespace LockHeedCore
{
    public class Map
    {
        public string Id { get; set; }
        public List<Level> Levels { get; set; }

        public Map(string id, List<Level> levels)
        {
            this.Id = id;
            this.Levels = levels;
        }

        public static Map generateMap()
        {
            DoorPosition prevLevelDoorPosition = DoorPosition.Bottom;
            List<Level> levels = new List<Level>(10);
            for (int levelNumber = 1; levelNumber <= 10; levelNumber++)
            {
                List<Obstacle> obstacles = new List<Obstacle>();
                for (int obstNumber = 1; obstNumber <= 4; obstNumber++) //Generate 4 obstacles
                {
                    Obstacle obstacle = null;
                    switch (new Random().Next(1, 3))
                    {
                        case 1: obstacle = new ChestObstacle("testSource", obstNumber * 150, new Random().Next(80, 400), null); break;
                        case 2: obstacle = new DeadlyObstacle("testSource", obstNumber * 150, new Random().Next(80, 400)); break;
                        case 3: obstacle = new ObstructedObstacle("testSource", obstNumber * 150, new Random().Next(80, 400)); break;
                    }
                    obstacles.Add(obstacle);
                }

                List<Door> doors = new List<Door>(2);
                if (levelNumber == 1)
                {
                    Array values = Enum.GetValues(typeof(DoorPosition));
                    DoorPosition randomDoorPosition = (DoorPosition)values.GetValue(new Random().Next(values.Length));
                    doors.Add(new Door(randomDoorPosition,levelNumber+1,"testSource"));
                    prevLevelDoorPosition = Door.getOppositePosition(randomDoorPosition);
                }
                else if (levelNumber >= 1 && levelNumber <= 10)
                {
                    doors.Add(new Door(prevLevelDoorPosition, levelNumber - 1, "testSource"));
                    Array values = Enum.GetValues(typeof(DoorPosition));
                    DoorPosition randomDoorPosition = (DoorPosition)values.GetValue(new Random().Next(values.Length));
                    if (randomDoorPosition == prevLevelDoorPosition)
                    {
                        randomDoorPosition = Door.getOppositePosition(randomDoorPosition);
                    }
                    doors.Add(new Door(randomDoorPosition, levelNumber + 1, "testSource"));
                    prevLevelDoorPosition = Door.getOppositePosition(randomDoorPosition);
                }
                else
                {
                    doors.Add(new Door(prevLevelDoorPosition, levelNumber - 1, "testSource"));
                }

                Level level = new Level(levelNumber, "testBackground", obstacles, doors);
                levels.Add(level);
            }         
            return new Map("map1", levels);
        }

        public override string ToString()
        {
            return String.Join(Environment.NewLine, this.Levels);
        }

    }
}