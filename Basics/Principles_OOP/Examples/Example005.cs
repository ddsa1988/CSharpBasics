namespace Basics.Principles_OOP.Examples;

public class Example005 {
    public static void UserMain() {
        var cat = new Cat();
        var dog = new Dog();

        cat.PrintInformation();
        Console.WriteLine();
        dog.PrintInformation();
    }

    private abstract class Animal {
        public void PrintInformation() {
            Console.WriteLine($"I am a {this.GetType().Name}.");
            Console.WriteLine(GetSound());
        }

        public abstract string GetSound();
    }

    private class Cat : Animal {
        public override string GetSound() {
            return "Meow!";
        }
    }

    private class Dog : Animal {
        public override string GetSound() {
            return "Au-Au!";
        }
    }
}