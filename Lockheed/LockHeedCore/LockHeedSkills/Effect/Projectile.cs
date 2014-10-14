using System;
using System.Collections.Generic;

namespace LockHeedCore
{

    public class Projectile : Effect
    {
        private string sourceImage;
        private double distance;
        private double x;
        private double y;
        private double deltaX;
        private double deltaY;

        

        public static List<Projectile> projectiles = new List<Projectile>();


        public Projectile(string sourceImage, int distance, double x,double y,double deltaX, double deltaY) 
            :base(sourceImage,distance,x,y)
        {          
            this.deltaX = deltaX;
            this.deltaY = deltaY;       
            projectiles.Add(this);
        }

        public static void MoveProjectiles()
        {
            foreach (var proj in projectiles) 
            {
                proj.x += proj.deltaX * MovementModifier;
                proj.y += proj.deltaY * MovementModifier;
                proj.distance -= Math.Sqrt(Math.Pow(proj.deltaX * MovementModifier,2) + Math.Pow(proj.deltaY * MovementModifier,2));

                if(CheckCollision(proj) || proj.distance<=0)
                {
                    projectiles.Remove(proj);                  
                }
            }
        }

        public static bool CheckCollision(Projectile projectile)
        {
            return true;
        }


    }
}
