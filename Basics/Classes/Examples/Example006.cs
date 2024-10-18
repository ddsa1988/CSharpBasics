namespace Basics.Classes.Examples;

public class Example006 {
    // Static methods
    public static void UserMain() {
        Console.WriteLine(Dog.GetDogCounter1());
        Console.WriteLine();

        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        Dog dog3 = new Dog();

        Console.WriteLine(Dog.GetDogCounter1());
        Console.WriteLine(dog1.GetDogCounter2());
        Console.WriteLine(dog2.GetDogCounter2());
        Console.WriteLine(dog3.GetDogCounter2());
    }

    private class Dog {
        private static int dogCounter = 0;

        public Dog() {
            dogCounter++;
        }

        public static int GetDogCounter1() {
            return dogCounter;
        }

        public int GetDogCounter2() {
            return GetDogCounter1();
        }
    }
}