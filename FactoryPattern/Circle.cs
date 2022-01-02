using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Shape");
        }
    }
}
