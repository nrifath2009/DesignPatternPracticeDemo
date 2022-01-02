using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.ObserverPattern
{
    public class NotificationChannel
    {
        private List<Notification> notifications = new List<Notification>();
        private string NotificationContent;

        public void Attach(Notification notification)
        {
            this.notifications.Add(notification);
        }
        public string GetNotificationContent()
        {
            return NotificationContent;
        }
        public void SendNotification(string notificationContent)
        {
            this.NotificationContent = notificationContent;
            NotifyAllObserver();
        }
        public void NotifyAllObserver()
        {
            foreach (var notification in notifications)
            {
                notification.Send();
            }
        }
    }
}
