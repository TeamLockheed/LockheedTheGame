using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockHeedCore
{
    public interface IMoveable
    {
        float X { get; set;}
        float Y { get; set; }

        void Move();

    }
}
