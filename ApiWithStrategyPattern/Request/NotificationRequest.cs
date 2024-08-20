using System;

namespace ApiWithStrategyPattern.Request;

public class NotificationRequest
{
    public string Channel { get; set; } = string.Empty;

    public string Destination { get; set; } = string.Empty;

    public string Menssage { get; set; } = string.Empty;
}
