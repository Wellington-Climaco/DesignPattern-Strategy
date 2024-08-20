using System;

namespace ApiWithStrategyPattern.Service.Strategy;

public class DiscordNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string destination, string message)
    {
        System.Console.WriteLine($"Notificação do discord {message} enviada para {destination}");	
    }
}
