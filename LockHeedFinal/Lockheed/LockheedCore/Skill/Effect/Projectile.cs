using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.Window;
namespace LockHeedCore
{

    public class Projectile : Effect
    {

        public double Distance { get; set; }

        public float DeltaX { get; private set; }
        public float DeltaY { get; private set; }
        public float ProjectileSpeed { get; private set; }

        public bool IsActive { get; set; }

        public static List<Projectile> projectiles = new List<Projectile>();

        public Projectile(SpriteSheet sprite, float x, float y, float deltaX, float deltaY, float projectileSpeed) 
            :base(sprite,x,y)
        {          
            this.DeltaX = deltaX;
            this.DeltaY = deltaY;
            this.ProjectileSpeed = projectileSpeed;
            this.Distance = 1000;
            this.BoundingBox = new FloatRect(this.SpriteSheet.CurrentSprite.GetGlobalBounds().Left, this.SpriteSheet.CurrentSprite.GetGlobalBounds().Top, 20, 20);
            this.IsActive = true;
             projectiles.Add(this);
        }

      
        public override void Move()
        {
            if (this.IsActive) { 

            this.X += this.DeltaX * this.ProjectileSpeed;
            this.Y += this.DeltaY * this.ProjectileSpeed;      

            }
            if (CheckCollision() )
            {
                this.IsActive = false;
            }
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.X, this.Y);
            this.BoundingBox = new FloatRect(this.SpriteSheet.CurrentSprite.GetGlobalBounds().Left, this.SpriteSheet.CurrentSprite.GetGlobalBounds().Top, 20, 20);
         
        }

        public static void deleteInactive() {
            projectiles.RemoveAll(item => item.IsActive == false);      
        }

        public bool CheckCollision()
        {
            foreach (var enemy in EntityManager.CurrentLevel.Enemies)
            {
                if (this.BoundingBox.Intersects(enemy.BoundingBox))
                {
                    enemy.IsDead = true;
                    return true;
                }
            
            }
            return false;         
        }


    }
}
