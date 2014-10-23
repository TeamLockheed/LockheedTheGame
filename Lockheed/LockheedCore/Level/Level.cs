using LockHeedCore.Exceptions;

namespace LockHeedCore
{
    using System;
    using System.Collections.Generic;

    using System.Text;
    using SFML.Graphics;

    public class Level : IDrawable
    {
        private int id;
        private List<Obstacles> obstacles;
        public SpriteSheet SpriteSheet { get; set; }
        public List<Door> Doors = new List<Door>(2);
        public List<Enemy> Enemies { get; set; }

        public Level(int id, List<Obstacle> obstacles)
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
            foreach (var door in this.Doors)
            {
                door.Draw(window);
            }
            foreach (var obstacle in this.Obstacles)
            {
                obstacle.Draw(window);
            }
        }

        public override string ToString()
        {
            return String.Join(", ", this.Doors.ToString());
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 0, "Id cannot be negative!");
                this.id = value;
            }
        }

        public List<Obstacle> Obstacles
        {
            get
            {
                return this.obstacles;
            }
            set
            {
                ExceptionsHolder.CheckEmptyCollections(value, "Something wrong! There are no obstacles!");
                this.obstacles = value;
            }
        }
    }
}
