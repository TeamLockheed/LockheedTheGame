using System;
using System.Collections.Generic;

namespace LockHeedCore
{

    public class Projectile : Effect
    {

        public double Distance { get; set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double DeltaX { get; private set; }
        public double DeltaY { get; private set; }
        public int ProjectileSpeed { get; private set; }

        public static List<Projectile> projectiles = new List<Projectile>();

        public Projectile(string sourceImage, double x,double y,double deltaX, double deltaY,int projectileSpeed) 
            :base(sourceImage,x,y)
        {          
            this.DeltaX = deltaX;
            this.DeltaY = deltaY;
            this.ProjectileSpeed = projectileSpeed;
            projectiles.Add(this);
        }

        public void MoveProjectile()
        {
            this.X += this.DeltaX * this.ProjectileSpeed;
            this.Y += this.DeltaY * this.ProjectileSpeed;
            this.Distance -= Math.Sqrt(Math.Pow(this.DeltaX * this.ProjectileSpeed, 2) + Math.Pow(this.DeltaY * this.ProjectileSpeed, 2));

            if (CheckCollision(this) || this.Distance <= 0)
                {
                    projectiles.Remove(this);                  
                }         
        }

        public bool CheckCollision(Projectile projectile)
        {
            throw new NotImplementedException("Under construction");
            
        }


    }
}
