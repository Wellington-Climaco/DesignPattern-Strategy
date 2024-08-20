using System;

namespace ApiWithStrategyPattern.Service;

public interface INotificationStrategy
{
    public void SendNotification(string destination,string message);
}
