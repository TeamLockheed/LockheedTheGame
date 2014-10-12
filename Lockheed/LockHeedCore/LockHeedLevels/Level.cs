using System;
using System.Collections.Generic;


namespace LockHeedCore
{
    using SFML.Audio;
    using SFML.Window;
    using SFML.Graphics;

    public enum DoorPosition { Left, Right, Top, Bottom };
    public class Level
    {
        public string Name { get; set; }
        public string Background { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public List<Door> Doors { get; set; }

        public Level(string name,string background,List<Obstacle> obstacles,List<Door> doors)
        {
            this.Name = name;
            this.Background = background;
            this.Obstacles = obstacles;
            this.Doors = doors;
        }

        public static void DrawLevel(Level level,RenderWindow window) 
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


    }
}
