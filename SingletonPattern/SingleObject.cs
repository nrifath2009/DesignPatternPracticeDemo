using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.SingletonPattern
{
    public class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject() { }

        public static SingleObject GetInstance()
        {
            return instance;
        }
        public void ShowMessage()
        {
            Console.WriteLine("I am singleton");
        }

    }
}
