using System;

namespace ApiWithStrategyPattern.Service.Strategy;

public class WhatsappNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string destination, string message)
    {
        System.Console.WriteLine($"Notificação do whatsapp {message} enviada para {destination}");	
    }
}
