using DesignPatterns.Coupling.Interfaces;

namespace DesignPatterns.Coupling.Models;

public class SmsSender : INotificationService {
    public void SendNotification(string msg) {
        Console.WriteLine("Sending sms: " + msg);
    }
}