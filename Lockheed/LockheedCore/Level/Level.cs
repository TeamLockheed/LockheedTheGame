using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
namespace LockHeedCore
{

    public class Level : IDrawable
    {
        public int Id { get; set; }
        public SpriteSheet SpriteSheet { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public List<Door> Doors = new List<Door>(2);
        public List<Enemy> Enemies { get; set; }

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
        }

        public override string ToString()
        {

            return String.Join(", ", this.Doors.ToString());
           
        }

    }
}
