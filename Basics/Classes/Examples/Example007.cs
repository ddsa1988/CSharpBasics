namespace Basics.Classes.Examples;

public class Example007 {
    // Static methods
    public static void UserMain() {
        Console.WriteLine(Dog.DogCounter);
        Console.WriteLine();

        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        Dog dog3 = new Dog();

        Console.WriteLine(Dog.DogCounter);
        Console.WriteLine(dog1.GetDogCounter);
        Console.WriteLine(dog2.GetDogCounter);
        Console.WriteLine(dog3.GetDogCounter);
    }

    private class Dog {
        public static int DogCounter { get; private set; } = 0;

        public Dog() {
            DogCounter++;
        }

        public int GetDogCounter {
            get { return DogCounter; }
        }
    }
}