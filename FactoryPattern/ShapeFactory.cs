using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.FactoryPattern
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType == "CIRCLE")
            {
                return new Circle();
            }
            else if (shapeType == "RECTANGLE")
            {
                return new Rectangle();
            }
            else if (shapeType == "SQUARE")
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }
    }
}
