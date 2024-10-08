namespace Basics.UsingObjects.Exercises;

using Basics.UsingObjects.Models;

public class Exercise008 {
    // Write a program which creates 10 objects of type Cat, gives them names CatN, where N is a 
    // unique serial number of the object, and in the end call the method MakeSound() for each of them.
    public static void UserMain() {
        const int size = 10;
        Cat[] cats = new Cat[size];

        for (int i = 0; i < size; i++) {
            string catName = "Cat" + Sequence.NextValue();

            cats[i] = new Cat();
            cats[i].Name = catName;
        }

        foreach (Cat cat in cats) {
            Console.WriteLine(cat);
            cat.MakeSound();

            Console.WriteLine();
        }
    }
}