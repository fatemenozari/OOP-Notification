using System;
namespace OOP.Notification
{
    public interface INotificationProvider
    {
        void Send(string to, string message);
        NotificationType GetNotificationType();
        bool ActionProvider(List<NotificationType> notificationType);
        bool StatusProvider();


    }
}

