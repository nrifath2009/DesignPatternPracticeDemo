using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.ObserverPattern
{
    public class SMSNotification : Notification
    {
        public SMSNotification(NotificationChannel notificationChannel)
        {
            this.notificationChannel = notificationChannel;
            this.notificationChannel.Attach(this);
        }
        public override void Send()
        {
            Console.WriteLine("Sending SMS..." + notificationChannel.GetNotificationContent());
        }
    }
}
