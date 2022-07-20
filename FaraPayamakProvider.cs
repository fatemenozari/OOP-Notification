using System;
namespace OOP.Notification
{
    public class FaraPayamakProvider : INotificationProvider
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Send {GetNotificationType()} to {to} message {message}");
        }

        public NotificationType GetNotificationType()
        {
            return NotificationType.Farapayamak;
        }
    }
}

