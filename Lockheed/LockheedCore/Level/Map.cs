using System;
using System.Collections.Generic;


namespace LockHeedCore
{

    public class Map
    {
        private static readonly Random random = new Random();
        public string Id { get; set; }
        public Level[,] Levels = new Level[21, 21];


        public Map(string id)
        {
            this.Id = id;

        }

        public static Map generateMap()
        {
            DoorPosition prevLevelDoorPosition = DoorPosition.Bottom;
            Level[,] tempLevels = new Level[21, 21];
            int arrayPosX = 10;
            int arrayPoxY = 10;
            for (int levelNumber = 1; levelNumber <= 10; levelNumber++)
            {
                List<Obstacle> obstacles = new List<Obstacle>();
                for (int obstNumber = 1; obstNumber <= 4; obstNumber++) //Generate 4 obstacles
                {
                    Obstacle obstacle = null;
                    switch (random.Next(1, 4))
                    {
                        case 1: obstacle = new ChestObstacle( obstNumber * 150, new Random().Next(80, 400), null); break;
                        case 2: obstacle = new DeadlyObstacle( obstNumber * 150, new Random().Next(80, 400)); break;
                        case 3: obstacle = new ObstructedObstacle( obstNumber * 150, new Random().Next(80, 400)); break;
                    }
                    obstacles.Add(obstacle);
                }

                List<Door> doors = new List<Door>(2);
                DoorPosition randomDoorPosition = Door.getRandomPosition();
                if (levelNumber == 1)
                {                  
                    doors.Add(new Door(randomDoorPosition,levelNumber+1));                  
                    prevLevelDoorPosition = Door.getOppositePosition(randomDoorPosition);
                }
                else if (levelNumber > 1 && levelNumber < 10)
                {
                    doors.Add(new Door(prevLevelDoorPosition, levelNumber - 1));
                        
                    if (randomDoorPosition == prevLevelDoorPosition)
                    {
                        randomDoorPosition = Door.getOppositePosition(randomDoorPosition);
                    }
                    
                    doors.Add(new Door(randomDoorPosition, levelNumber + 1));
                    prevLevelDoorPosition = Door.getOppositePosition(randomDoorPosition);
                }
                else
                {
                    doors.Add(new Door(prevLevelDoorPosition, levelNumber - 1));
                }

                Level level = new Level(levelNumber, obstacles);
                level.Doors = doors;
                tempLevels[arrayPosX, arrayPoxY] = level;
                switch (randomDoorPosition)
                {
                    case DoorPosition.Top: arrayPoxY--; break;
                    case DoorPosition.Bottom: arrayPoxY++; break;
                    case DoorPosition.Left: arrayPosX--; break;
                    case DoorPosition.Right: arrayPosX++; break;
                }
          
            }
            Map map = new Map("map1");
            map.Levels = tempLevels;
            return map;
        }

    

        

        public override string ToString()
        {
            return String.Join(Environment.NewLine, this.Levels);
        }

    }
}