using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo.ObserverPattern
{
    public abstract class Notification
    {
        protected NotificationChannel notificationChannel;
        public abstract void Send();
    }
}
