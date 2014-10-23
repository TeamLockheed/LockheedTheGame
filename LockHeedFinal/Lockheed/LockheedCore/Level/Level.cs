using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
namespace LockHeedCore
{

    public class Level : IDrawable
    {
        private static readonly Random random = new Random();

        public int Id { get; set; }
        public SpriteSheet SpriteSheet { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public List<Door> Doors = new List<Door>(2);
        public List<Enemy> Enemies = new List<Enemy>(10);

        public Level(int id,List<Obstacle> obstacles)
        {
            this.Id = id;
            this.Obstacles = obstacles ?? new List<Obstacle>();
            this.SpriteSheet = new SpriteSheet(new Sprite(new Texture("level/baseLevel.png")));
        }


        public void checkDoors()
        {
            if (this.Enemies == null)
            {
                foreach (var door in this.Doors)
                {
                    door.IsOpen = true;
                }
            }
        }


        public void Draw(RenderTarget window)
        { 
           window.Draw(this.SpriteSheet.CurrentSprite);
            foreach(var door in this.Doors)
            {
               door.Draw(window);
            }
            foreach(var obstacle in this.Obstacles)
            {
               obstacle.Draw(window);
            }
            foreach (var enemy in this.Enemies)
            {
                enemy.Draw(window);
            }
        }

        public void RemoveDead()
        {
            this.Enemies.RemoveAll(item => item.IsDead == true);
        }

        public static Level GenerateSingleLevel()
        {
            List<Enemy> enemies = new List<Enemy>();
            for (int enemyNum = 1; enemyNum <= random.Next(1, 11); enemyNum++)
            {
                enemies.Add(new Enemy());
            }

            List<Obstacle> obstacles = new List<Obstacle>();
            for (int obstNumber = 1; obstNumber <= 4; obstNumber++) //Generate 4 obstacles
            {
                Obstacle obstacle = null;
                switch (random.Next(1, 4))
                {
                    case 1: obstacle = new ChestObstacle(obstNumber * 150, random.Next(80, 350), null); break;
                    case 2: obstacle = new DeadlyObstacle(obstNumber * 150, random.Next(80, 350)); break;
                    case 3: obstacle = new ObstructedObstacle(obstNumber * 150, random.Next(80, 350)); break;
                }
                obstacles.Add(obstacle);
            }
                  List<Door> doors = new List<Door>(2);
                  DoorPosition randomDoorPosition = Door.getRandomPosition();                            
                  doors.Add(new Door(randomDoorPosition,222));
                  Level level = new Level(222, obstacles);
                  level.Enemies = enemies;
                  level.Doors = doors;
                  return level;             
        }

        public override string ToString()
        {

            return String.Join(", ", this.Doors.ToString());
           
        }

    }
}
