using OOP.Notification;

var messageService = new MessageService();

var phoneNumbers = new List<string>() { "912123", "933123", "930123", "915345" };

var message = "hello world";

var notificationTypes = new List<NotificationType>() { NotificationType.Farapayamak, NotificationType.Rahyab };

//TODO:For fatemeh
var x = ((phoneNumbers.Count() * 50) / 100);

var lastProvider = NotificationType.Rahyab;

var lastPhoneNumbers = new List<string>();

//TODO:For masoud :D
foreach (var item in notificationTypes)
{
    var currentProvider = GetProvider(item);

    foreach (var p in phoneNumbers.Take(x))
    {
        lastPhoneNumbers.Add(p);
        messageService.Send(p, message, new List<NotificationType>() { currentProvider });
    }
    lastProvider = currentProvider;

    //TODO:For marie
    foreach (var p2 in phoneNumbers.Except(lastPhoneNumbers))
    {
        //TODO:For marie
        var currentProvider2 = GetProvider(lastProvider);
        messageService.Send(p2, message, new List<NotificationType>() { currentProvider2 });
    }

    break;
}

Console.ReadKey();

static NotificationType GetProvider(NotificationType notificationType)
{
    switch (notificationType)
    {
        case NotificationType.Rahyab:
            {
                return NotificationType.Farapayamak;
            }
        case NotificationType.Farapayamak:
            {
                return NotificationType.Rahyab;
            }
        default:
            return NotificationType.Rahyab;

    }
}