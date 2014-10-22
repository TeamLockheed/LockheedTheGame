using System;
using SFML.Graphics;
using SFML.System;

namespace LockHeedCore
{
    public static class Renderer
    {
        public static void DrawLevel(this Level level, RenderTarget renderer)
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

        public static void DrawCharacter(this Character character, RenderTarget renderer)
        {
            Sprite legs = new Sprite(new Texture(character.Legs));
            legs.Position = new Vector2f(character.X, character.Y + 10);
            renderer.Draw(legs);
            Sprite body = new Sprite(new Texture(character.Body));
            body.Position = new Vector2f(character.X, character.Y + 30);
            renderer.Draw(body);
            Sprite head = new Sprite(new Texture(character.HeadPiece));
            head.Position = new Vector2f(character.X, character.Y + 50);
            renderer.Draw(head);


        }
    }
}
