namespace Basics.Loops;

public class Exercise003 {
    // Write a program that reads from the console a positive integer number
    // N (N < 20) and prints a matrix of numbers as on the figures below:

    // N=4
    // 1234
    // 2345
    // 3456
    // 4567

    public static void UserMain() {
        const int minValue = 1;
        const int maxValue = 20;

        int number;

        while (true) {
            Console.Write($"Type a positive integer number from {minValue} to {maxValue}: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number >= minValue && number <= maxValue;

            if (!isNumberValid) continue;

            break;
        }

        for (int i = 0; i < number; i++) {
            for (int j = 1; j <= number; j++) {
                string result = (j + i).ToString("D2");
                Console.Write(result + " ");
            }

            Console.WriteLine();
        }
    }
}