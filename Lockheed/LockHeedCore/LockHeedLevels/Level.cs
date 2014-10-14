using System;
using System.Collections.Generic;
using SFML.Audio;
using SFML.Window;
using SFML.Graphics;

namespace LockHeedCore
{

    public class Level
    {
        public string Name { get; set; }
        public string Background { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public List<Door> Doors { get; set; }

        public Level(string name,string background,List<Obstacle> obstacles=null,List<Door> doors=null)
        {
            this.Name = name;
            this.Background = background;
            this.Obstacles = obstacles ?? new List<Obstacle>();
            this.Doors = doors ?? new List<Door>(4);
        }

        public static void DrawLevel(Level level,RenderTarget renderer) 
        {
            RectangleShape background = new RectangleShape();
            background.Position = new Vector2f(0, 0);
            background.Size = new Vector2f(800, 450);
            background.Texture = new Texture(level.Background);

            renderer.Draw(background);
            foreach (var obstacle in level.Obstacles)
            {
                Sprite obstSprite = new Sprite();
                obstSprite.Texture = new Texture(obstacle.SourceImage);
                obstSprite.Position = new Vector2f(obstacle.X, obstacle.Y);
                renderer.Draw(obstSprite);
            }
            foreach (var door in level.Doors)
            {
                Sprite doorSprite = new Sprite();
                doorSprite.Texture = new Texture(door.SourceImage);
                doorSprite.Position = new Vector2f(door.X, door.Y);
                renderer.Draw(doorSprite);
            }

        }


    }
}
