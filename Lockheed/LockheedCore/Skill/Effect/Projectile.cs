using LockHeedCore.Exceptions;

namespace LockHeedCore
{
    using System;
    using System.Collections.Generic;

    public class Projectile : Effect
    {
        private double deltaX;
        private double deltaY;
        private int projectileSpeed;
        public double Distance { get; set; }
        public double X { get; private set; }
        public double Y { get; private set; }

        public static List<Projectile> projectiles = new List<Projectile>();

        public Projectile(string sourceImage, double x, double y, double deltaX, double deltaY, int projectileSpeed)
            : base(sourceImage, x, y)
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

        public double DeltaX
        {
            get
            {
                return this.deltaX;
            }
            private set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 1, "DeltaX cannot be 0 or negative!");
                this.deltaX = value;
            }
        }

        public double DeltaY
        {
            get
            {
                return this.deltaY;
            }
            private set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 1, "DeltaY cannot be 0 or negative!");
                this.deltaY = value;
            }
        }

        public int ProjectileSpeed
        {
            get
            {
                return this.projectileSpeed;
            }
            private set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 1, "Projectile Speed cannot be 0 or negative!");
                this.projectileSpeed = value;
            }
        }
    }
}
