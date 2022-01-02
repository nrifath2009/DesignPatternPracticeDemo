using DesignPatternDemo.FactoryPattern;
using DesignPatternDemo.ObserverPattern;
using DesignPatternDemo.SingletonPattern;
using DesignPatternDemo.StrategyPattern;
using System;

namespace DesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // FACTORY DESIGN PATTERN
            //IShape circleShape =  ShapeFactory.GetShape("CIRCLE");
            //circleShape.Draw();

            //IShape rectangleShape = ShapeFactory.GetShape("RECTANGLE");
            //rectangleShape.Draw();

            //IShape squareShape = ShapeFactory.GetShape("SQUARE");
            //squareShape.Draw();

            //Singleton DESIGN Pattern
            //SingleObject singleObject = SingleObject.GetInstance();
            //singleObject.ShowMessage();

            //Strategy DESIGN Pattern
            //Calculator calculator = new Calculator(new AddOperation());
            //Console.WriteLine("Add Operation: "+calculator.Execute(10, 5));

            //calculator = new Calculator(new SubtractOperation());
            //Console.WriteLine("Subtract Operation: " + calculator.Execute(10, 5));

            //calculator = new Calculator(new MultiplyOperation());
            //Console.WriteLine("Multiply Operation: " + calculator.Execute(10, 5));

            //Observer Pattern
            NotificationChannel notificationChannel = new NotificationChannel();

            new EmailNotification(notificationChannel);
            new SMSNotification(notificationChannel);
            //new PushNotification(notificationChannel);

            notificationChannel.SendNotification("All Good");

            Console.ReadKey();
        }
    }
}
