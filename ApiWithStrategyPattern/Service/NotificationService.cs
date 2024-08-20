using System;
using ApiWithStrategyPattern.Service.Strategy;

namespace ApiWithStrategyPattern.Service;

public class NotificationService
{
    private Dictionary<string,INotificationStrategy> _notificationStrategies = new Dictionary<string,INotificationStrategy>()
    {
        {"discord", new DiscordNotificationStrategy() },
        {"email", new EmailNotificationStrategy() },
        {"whatsapp", new WhatsappNotificationStrategy()}
    };
    public void Notify(string channel,string message,string destination)
    {
        if (_notificationStrategies.TryGetValue(channel, out var strategy))
        {
            strategy.SendNotification(destination,message);
        }
        else
        {
            System.Console.WriteLine("Não encontrado");
        }
    }
}
