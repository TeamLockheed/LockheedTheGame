using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Graphics;
using SFML.Window;
using System.Reflection;
namespace LockHeedCore
{
    public static class EntityManager
    {



        public static Level CurrentLevel;
        public static Character Character;

        public static RectangleShape healthRect = new RectangleShape();
        public static RectangleShape manaRect = new RectangleShape();

         

        public static void Update()
        {
            Character.Update();
            Character.Move();
            foreach (var enemy in CurrentLevel.Enemies)
            {
                enemy.Update(Character);
                enemy.Move();
            }
            CurrentLevel.RemoveDead();
            foreach (var projectile in Projectile.projectiles)
            {
                projectile.Move();
            }
            Projectile.deleteInactive();
        }
        public static void Draw(RenderTarget window)
        {
           
            
            healthRect.Position = new Vector2f(Character.X, Character.Y - 10);
            healthRect.Size = new Vector2f(Character.Stats.Health * 0.6f, 5);
            
            manaRect.Position = new Vector2f(Character.X, Character.Y - 3);
            manaRect.Size = new Vector2f(Character.Stats.Mana * 0.6f, 5);

            healthRect.FillColor = Color.Red;
            manaRect.FillColor = Color.Blue;

            CurrentLevel.Draw(window);
            Character.Draw(window);

            foreach (var projectile in Projectile.projectiles)
            {
                projectile.Draw(window);
            }
         

            window.Draw(healthRect);
            window.Draw(manaRect);
        }

    }
}
