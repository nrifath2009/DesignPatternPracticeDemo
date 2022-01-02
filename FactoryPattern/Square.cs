using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryPattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square Shape");
        }
    }
}
