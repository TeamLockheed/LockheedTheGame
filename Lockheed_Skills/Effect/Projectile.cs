

namespace TestSFML
{
    using System;
    using System.Collections.Generic;

    public class Projectile : Effect
    {
        private string sourceImage;
        private double distance;
        private double X;
        private double Y;
        private double deltaX;
        private double deltaY;

        

        public static List<Projectile> projectiles = new List<Projectile>();


        public Projectile(string sourceImage, int distance, double X,double Y,double deltaX, double deltaY) 
            :base(sourceImage,distance,X,Y)
        {          
            this.deltaX = deltaX;
            this.deltaY = deltaY;       
            projectiles.Add(this);
        }

        public static void MoveProjectiles()
        {
            foreach (var proj in projectiles) 
            {
                proj.X += proj.deltaX * MovementModifier;
                proj.Y += proj.deltaY * MovementModifier;
                proj.distance -= Math.Sqrt(Math.Pow(proj.deltaX * MovementModifier,2) + Math.Pow(proj.deltaY * MovementModifier,2));

                if(CheckCollision(proj) || proj.distance<=0)
                {
                    projectiles.Remove(proj);                  
                }
            }
        }

        public static override bool CheckCollision(Projectile projectile)
        {
            return true;

        }


    }
}
