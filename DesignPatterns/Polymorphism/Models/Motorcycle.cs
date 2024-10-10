namespace DesignPatterns.Polymorphism.Models;

public class Motorcycle : Vehicle {
    public int NumberOfWheels { get; set; }

    public override void Start() {
        Console.WriteLine("Motorcycle is starting...");
    }

    public override void Stop() {
        Console.WriteLine("Motorcycle is stopping...");
    }
}