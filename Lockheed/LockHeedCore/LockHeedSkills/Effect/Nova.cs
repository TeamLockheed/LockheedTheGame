using System;


namespace LockHeedCore
{
    
    public class Nova : Effect
    {
        private string directory;
        private int radius;
        private double X;
        private double Y;



        public Nova(string directory, int radius, double X, double Y)
            : base(directory, radius, X, Y)
        {      
        }

        public void MoveNova() 
        { 
            
        }

        public bool CheckCollision(Nova nova)
        {
            return true;

        }
    }
}
