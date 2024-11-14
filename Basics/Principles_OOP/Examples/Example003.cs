namespace Basics.Principles_OOP.Examples;

public class Example003 {
    public static void UserMain() {
        var car = new Car();
        var motorcycle = new Motorcycle();

        car.Start();
        car.Stop();

        Console.WriteLine();

        motorcycle.Start();
        motorcycle.Stop();
    }

    private class Car : IControl {
        public void Start() {
            Console.WriteLine("Car is starting...");
        }

        public void Stop() {
            Console.WriteLine("Car is stopping...");
        }
    }

    private class Motorcycle : IControl {
        public void Start() {
            Console.WriteLine("Motorcycle is starting...");
        }

        public void Stop() {
            Console.WriteLine("Motorcycle is stopping...");
        }
    }
}

public interface IControl {
    public void Start();
    public void Stop();
}