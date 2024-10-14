namespace DesignPatterns.Composition.Models;

public class Car {
    Engine engine = new Engine();
    Wheels wheels = new Wheels();
    Chassis chassis = new Chassis();
    Seats seats = new Seats();

    public void Start() {
        engine.Start();
        wheels.Rotate();
        chassis.Support();
        seats.Sit();

        Console.WriteLine("Car started.");
    }
}