using System;
namespace OOP.Notification
{
    public interface IMessageService
    {
        void Send(string to, string message, List<NotificationType> notificationTypes);
    }
}

