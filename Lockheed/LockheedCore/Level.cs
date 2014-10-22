namespace LockHeedCore
{
    using System;
    using System.Collections.Generic;

    using Exceptions;

    using SFML.Audio;
    using SFML.Window;
    using SFML.Graphics;

    public enum DoorPosition
    {
        Left,
        Right,
        Top,
        Bottom
    };

    public class Level
    {
        private string name;
        private string background;
        private List<Obstacle> obstacles;
        private List<Door> doors; 

        public Level(string name, string background, List<Obstacle> obstacles, List<Door> doors)
        {
            this.Name = name;
            this.Background = background;
            this.Obstacles = obstacles;
            this.Doors = doors;
        }

        public static void DrawLevel(Level level, RenderWindow window)
        {
            RectangleShape background = new RectangleShape();

            background.Position = new Vector2f(0, 0);
            background.Size = new Vector2f(800, 450);
            background.Texture = new Texture(level.Background);
            window.Draw(background);

            foreach (var obstacle in level.Obstacles)
            {
                Sprite obstSprite = new Sprite();
                obstSprite.Texture = new Texture(obstacle.SourceImage);
                obstSprite.Position = new Vector2f(obstacle.X, obstacle.Y);
                window.Draw(obstSprite);
            }

            foreach (var door in level.Doors)
            {
                Sprite doorSprite = new Sprite();
                doorSprite.Texture = new Texture(door.SourceImage);
                doorSprite.Position = new Vector2f(door.X, door.Y);
                window.Draw(doorSprite);
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                ExceptionsHolder.CheckNullableString(value, "Name cannot be null or empty!");
                this.name = value;
            }
        }

        public string Background
        {
            get
            {
                return this.background;
            }
            set
            {
                ExceptionsHolder.CheckNullableString(value, "BackGround cannot be null or empty!");
                this.background = value;
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
                ExceptionsHolder.CheckEmptyCollections(value, "Something wrong! There arent any obstacles!");
                this.obstacles = value;
            }
        }

        public List<Door> Doors
        {
            get
            {
                return this.doors;
            }
            set
            {
                ExceptionsHolder.CheckEmptyCollections(value, "Something wrong! There arent any doors!");
                this.doors = value;
            }
        }
    }
}
