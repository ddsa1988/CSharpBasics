using Basics.Principles_OOP.Models;

namespace Basics.Principles_OOP.Exercises;

public class Exercise005 {
    /*
    Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat. All of them are animals (Animal).
    Animals are characterized by age, name and gender. Each animal makes a sound (use a virtual method in the Animal class).
    Create an array of different animals and print on the console their name, age and the corresponding sound each one makes.
    */
    public static void UserMain() {
        Animal[] animals = [
            new Animal("Amora", 10, "female"),
            new Dog("Tom", 20, "male"),
            new Cat("Ameixa", 5, "female"),
        ];

        foreach (Animal animal in animals) {
            Console.WriteLine(animal);
            Console.WriteLine(animal.MakeSound() + "\n");
        }
    }
}