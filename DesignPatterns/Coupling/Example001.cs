using DesignPatterns.Coupling.Models;

namespace DesignPatterns.Coupling;

public class Example001 {
    // Coupling is the degree of dependency between different classes
    public static void UserMain() {
        Order order = new Order(new EmailSender());
        order.PlaceOrder();

        Console.WriteLine();

        order = new Order(new SmsSender());
        order.PlaceOrder();

        Console.WriteLine();
    }
}