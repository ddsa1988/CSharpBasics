namespace Basics.Methods.Exercises;

public class Exercise007 {
    // Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.
    public static void UserMain() {
        const int minValue = 0;
        const int maxValue = int.MaxValue;
        int number;

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number >= minValue && number <= maxValue;

            if (!isNumberValid) continue;

            break;
        }

        Console.Write($"The number {number} reversed is ");
        PrintNumberReversed(number);
    }

    public static void PrintNumberReversed(int number) {
        const int mod = 10;
        const int divisor = 10;

        int auxNumber = number;

        while (auxNumber > 0) {
            Console.Write(auxNumber % mod);
            auxNumber /= divisor;
        }

        Console.WriteLine();
    }
}