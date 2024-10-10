namespace DesignPatterns.Polymorphism;

using DesignPatterns.Polymorphism.Models;

public class Example001 {
    public static void UserMain() {
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Car() { Brand = "Toyota", Model = "Corolla", Year = 20242 });
        vehicles.Add(new Motorcycle() { Brand = "Triumph", Model = "Speed 400", Year = 2024 });

        foreach (Vehicle vehicle in vehicles) {
            vehicle.Start();
        }
    }
}