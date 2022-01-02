using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.StrategyPattern
{
    public interface IOperation
    {
        int Execute(int num1, int num2);
    }
}
