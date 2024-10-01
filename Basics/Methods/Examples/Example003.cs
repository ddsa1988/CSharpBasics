namespace Basics.Methods.Examples;

public class Example003 {
    public static void UserMain() {
        const int minValue = 1;
        const int maxValue = 10;

        int number;

        while (true) {
            Console.Write($"Type a positive integer number from {minValue} to {maxValue}: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number);

            if (!(isNumberValid && number >= minValue && number <= maxValue)) continue;

            break;
        }

        Console.WriteLine("");

        PrintTriangle(number);
    }

    private static void PrintTriangle(int n) {
        // Print the upper part of the triangle
        for (int i = 1; i <= n; i++) {
            PrintLine(1, i);
        }

        // Print the bottom part of the triangle
        for (int i = n - 1; i > 0; i--) {
            PrintLine(1, i);
        }
    }

    private static void PrintLine(int start, int end) {
        if (start < 1 || end < 1 || start > end) return;

        for (int i = start; i <= end; i++) {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}