namespace Basics.UsingObjects.Exercises;

using Basics.UsingObjects.Models;
using System.Reflection;

public class Exercise007 {
    // Define your own namespace CreatingAndUsingObjects and place in it two classes Cat and Sequence, which we used in the examples of the
    // current chapter. Define one more namespace and make a class, which calls the classes Cat and Sequence, in it.
    public static void UserMain() {
        Cat cat1 = new Cat("Test1", "Black");
        Cat cat2 = new Cat("Test2", "Black");

        Console.WriteLine(cat1);
        Console.WriteLine();

        Console.WriteLine(cat2);
        Console.WriteLine();

        Console.WriteLine(cat1.Equals(cat2));
        Console.WriteLine();

        Console.WriteLine(typeof(Cat));
        Console.WriteLine();

        cat1.MakeSound();
        Console.WriteLine();

        Console.WriteLine(Sequence.CurrentValue);
        Console.WriteLine(Sequence.NextValue());
        Console.WriteLine(Sequence.CurrentValue);
    }
}