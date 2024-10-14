using DesignPatterns.Composition.Models;

namespace DesignPatterns.Composition;

public class Example001 {
    // Composition involves creating complex objects by combining simpler objects or components.
    // Composition is often described in terms of a "has-a" relationship.
    public static void UserMain() {
        Car car = new Car();
        car.Start();
    }
}