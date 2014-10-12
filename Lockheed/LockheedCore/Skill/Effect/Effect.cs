


namespace TestSFML
{
    using System;

    public abstract class Effect
    {
        public const double MovementModifier = 5;

        private string directory;
        private int distance;
        private double x;
        private double y;

        public Effect(string directory, int distance, double x, double y) 
        {
            this.directory = directory;
            this.distance = distance;
            this.x = x;
            this.y = y;
        }

        public static abstract bool CheckCollision();

    }
}
