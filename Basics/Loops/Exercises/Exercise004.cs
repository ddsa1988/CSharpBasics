namespace Basics.Loops.Exercises;

public class Exercise004 {
    // Write a program that calculates with how many zeroes the factorial of a given number ends. Examples:
    // N = 10 -> N! = 3628800 -> 2
    // N = 20 -> N! = 2432902008176640000 -> 4
    public static void UserMain() {
        const int minValue = 0;
        const int maxValue = 20;

        int number;

        while (true) {
            Console.Write($"Type a positive integer number from {minValue} to {maxValue}: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number >= minValue && number <= maxValue;

            if (!isNumberValid) continue;

            break;
        }

        int counter = 0;
        long mod = 0;
        long factorial = Factorial(number);
        long temp = factorial;

        while (mod == 0) {
            mod = temp % 10;

            if (mod != 0) continue;

            temp = temp / 10;
            counter++;
        }

        Console.WriteLine($"The factorial of the number {number} is {factorial} and ends with {counter} zeros.");
    }

    private static long Factorial(int n) {
        long fact = 1;

        if (n < 2) return fact;

        for (int i = 2; i <= n; i++) {
            fact *= i;
        }

        return fact;
    }
}