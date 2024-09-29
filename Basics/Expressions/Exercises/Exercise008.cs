using System.Threading.Channels;

namespace Basics.Expressions.Exercises;

public class Exercise008 {
    // Write a program that checks if a given number n (1 < n < 100) is a prime number
    // (i.e. it is divisible without remainder only to itself and 1). 
    public static void UserMain() {
        const int minValue = 2;
        const int maxValue = 100;

        bool isPrimeNumber = true;
        int counter = 0;
        int number;

        while (true) {
            Console.Write($"Type a positive integer number from {minValue} to {maxValue}: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number >= minValue && number <= maxValue;

            if (!isNumberValid) continue;

            break;
        }

        for (int i = minValue; i <= number; i++) {
            if (number % i == 0) counter++;

            if (counter < 2) continue;

            isPrimeNumber = false;
            break;
        }

        string text = isPrimeNumber ? "is" : "isn't";

        Console.WriteLine($"The number {number} {text} prime number.");
    }
}