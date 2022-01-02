using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.StrategyPattern
{
    public class SubtractOperation : IOperation
    {
        public int Execute(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
