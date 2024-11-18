namespace Basics.Principles_OOP.Examples;
internal class Example006 {
    // Loose coupling
    public static void UserMain() {
        var order = new Order();

        order.PlaceOrder(new EmailSender());
        order.PlaceOrder(new SmsSender());
    }

    private class Order {
        private const string msg = "Order placed successfully.";
    
        public void PlaceOrder(INotificationService notification) {
            notification.SendNotification(msg);
        }
    }

    private class EmailSender : INotificationService {
        public void SendNotification(string msg) {
            Console.WriteLine("Sending email: " + msg);
        }
    }

    private class SmsSender : INotificationService {
        public void SendNotification(string msg) {
            Console.WriteLine("Sending sms: " + msg);
        }
    }
}

public interface INotificationService {
    public void SendNotification(string msg);
}
