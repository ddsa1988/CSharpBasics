using Basics.Generics.Models;

namespace Basics.Generics.Exercises;

public class Exercise001 {
    public static void UserMain() {
        GenericList<Dog> dogs = new GenericList<Dog>();
        dogs.Add(new Dog("1"));
        dogs.Add(new Dog("2"));
        dogs.Add(new Dog("3"));
        dogs.Add(new Dog("4"));
        dogs.Add(new Dog("5"));
        dogs.Add(new Dog("6"));
        dogs.Add(new Dog("7"));
        dogs.Add(new Dog("8"));
        dogs.Add(new Dog("9"));
        dogs.Add(new Dog("10"));

        dogs.RemoveByIndex(7);

        // Console.WriteLine(dogs.IndexOf(new Dog("6")));
        // dogs.AddByIndex(new Dog("100"), 8);
    }
}