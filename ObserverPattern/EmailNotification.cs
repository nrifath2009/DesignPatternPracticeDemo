using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.ObserverPattern
{
    public class EmailNotification : Notification
    {
        public EmailNotification(NotificationChannel notificationChannel)
        {
            this.notificationChannel = notificationChannel;
            this.notificationChannel.Attach(this);
        }
        public override void Send()
        {
            Console.WriteLine("Sending Email..."+notificationChannel.GetNotificationContent());
        }
    }
}
