using Basics.Principles_OOP.Models;

namespace Basics.Principles_OOP.Exercises;

public class Exercise001 {
    // Define a class Human with properties "first name" and "last name".
    // Define the class Student inheriting Human, which has the property "mark".
    // Define the class Worker inheriting Human with the property "wage" and "hours worked".
    // Implement a "calculate hourly wage" method, which calculates a worker’s hourly pay rate based on wage and hours worked.
    // Write the corresponding constructors and encapsulate all data in properties.
    public static void UserMain() {
        var human = new Human("Diego", "Alexandre");
        var student = new Student("Diego", "Alexandre", 80f);
        var worker = new Worker("Diego", "Alexandre", 500, 20);

        Console.WriteLine(human);
        Console.WriteLine();

        Console.WriteLine(student);
        Console.WriteLine();

        Console.WriteLine(worker);
    }
}