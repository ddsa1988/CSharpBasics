namespace Basics.Loops;

public class Exercise002 {
    // Write a program that reads from the console number N and print the sum
    // of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
    // 13, 21, 34, 55, 89, 144, 233, 377, ...
    public static void UserMain() {
        const int minValue = 1;
        const int maxValue = 90;

        int number;

        while (true) {
            Console.Write($"Type a positive integer number from {minValue} to {maxValue}: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number >= minValue && number <= maxValue;

            if (!isNumberValid) continue;

            break;
        }

        long actual = 0;
        long next = 1;

        Console.Write("Fibonacci sequence: ");

        for (int i = 0; i < number; i++) {
            Console.Write(actual + " ");

            long aux = actual + next;
            next = actual;
            actual = aux;
        }
    }
}