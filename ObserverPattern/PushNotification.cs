using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.ObserverPattern
{
    public class PushNotification : Notification
    {
        public PushNotification(NotificationChannel notificationChannel)
        {
            this.notificationChannel = notificationChannel;
            this.notificationChannel.Attach(this);
        }
        public override void Send()
        {
            Console.WriteLine("Sending Push Notification..." + notificationChannel.GetNotificationContent());
        }
    }
}
