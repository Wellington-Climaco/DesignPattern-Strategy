using System;

namespace ApiWithStrategyPattern.Service.Strategy;

public class EmailNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string destination, string message)
    {
        System.Console.WriteLine($"Notificação do email {message} enviada para {destination}");	
    }
}
