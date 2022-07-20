using System;

namespace OOP.Notification
{
    public class MessageService : IMessageService
    {
        private readonly INotificationProvider[] _notificationProviders;
        public MessageService()
        {
            _notificationProviders = new INotificationProvider[] { new RahyabProvider(), new FaraPayamakProvider() };
        }
        public void Send(string to, string message, List<NotificationType> notificationTypes)
        {
            foreach (var provider in _notificationProviders)
            {
                provider.Send(to, message);
            }
        }
    }
}

