using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.StrategyPattern
{
    public class Calculator
    {
        private IOperation operation;
        public Calculator(IOperation operation)
        {
            this.operation = operation;
        }
        public int Execute(int num1,int num2)
        {
            return operation.Execute(num1, num2);
        }
    }
}
