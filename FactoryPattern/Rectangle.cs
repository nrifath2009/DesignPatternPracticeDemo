using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Shape");
        }
    }
}
