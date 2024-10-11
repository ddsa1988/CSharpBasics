using DesignPatterns.Coupling.Interfaces;

namespace DesignPatterns.Coupling.Models;

public class EmailSender : INotificationService {
    public void SendNotification(string msg) {
        Console.WriteLine("Sending email: " + msg);
    }
}