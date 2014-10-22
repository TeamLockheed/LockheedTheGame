using System;
using SFML.Graphics;


namespace LockHeedCore
{
    public interface ICollidable
    {
        FloatRect BoundingBox { get; set; }
        bool CheckCollision(ICollidable collidable, ICollidable collidable2);
       
    }
}
