using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Graphics;
using System.Reflection;
namespace LockHeedCore
{
    public static class EntityManager
    {
        public static void Draw(RenderTarget window)
        {
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IDrawable))
                                     && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IDrawable;

            foreach (var instance in instances)
            {
                instance.Draw(window); // where Foo is a method of ISomething
            }
        
        }

    }
}
