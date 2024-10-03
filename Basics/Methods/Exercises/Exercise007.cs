namespace Basics.Methods.Exercises;

public class Exercise007 {
    // Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.
    public static void UserMain() {
        int number = 1;
        Console.WriteLine(number / 1 % 10);
        Console.WriteLine(number / 10 % 10);
        Console.WriteLine(number / 100 % 10);

        Console.WriteLine();

        Console.WriteLine(number / 10);
        Console.WriteLine(number / 100);
        Console.WriteLine(number / 1000);

        PrintNumberReversed(number);
    }

    public static void PrintNumberReversed(int number) {

    }
}