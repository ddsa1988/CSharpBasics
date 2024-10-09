namespace DesignPatterns.Inheritance;

public class Example001 {
    // Inheritance involver creating new classes based on existing classes.
    // Subclasses inherit properties and behaviors from their superclass.
    // Subclasses can add new features or override existing methods.
    // Inheritance is described in terms of an 'is-a' relationship.
    public static void UserMain() {
        Vehicle vehicle = new Vehicle();
        Car car = new Car();
        Bike bike = new Bike();

        Console.WriteLine(typeof(Vehicle).IsInstanceOfType(vehicle));
        Console.WriteLine(typeof(Vehicle).IsInstanceOfType(car));
        Console.WriteLine(typeof(Vehicle).IsInstanceOfType(bike));

        Console.WriteLine();

        Console.WriteLine(typeof(Car).IsInstanceOfType(vehicle));
        Console.WriteLine(typeof(Car).IsInstanceOfType(car));
        Console.WriteLine(typeof(Car).IsInstanceOfType(bike));

        Console.WriteLine();

        Console.WriteLine(typeof(Bike).IsInstanceOfType(vehicle));
        Console.WriteLine(typeof(Bike).IsInstanceOfType(car));
        Console.WriteLine(typeof(Bike).IsInstanceOfType(bike));
    }
}