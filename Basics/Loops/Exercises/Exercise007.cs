namespace Basics.Loops.Exercises;

public class Exercise007 {
    // Write a program that by a given integer N prints the numbers from 1 to N in random order.

    public static void UserMain() {
        const int minValue = 0;
        const int maxValue = 20;

        var random = new Random();
        var numbers = new HashSet<int>();

        int number;

        while (true) {
            Console.Write($"Type a positive integer number from {minValue} to {maxValue}: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number >= minValue && number <= maxValue;

            if (!isNumberValid) continue;

            break;
        }

        for (int i = 0; i <= number; i++) {
            while (true) {
                int value = random.Next(number + 1);

                if (!numbers.Add(value)) continue;

                Console.Write(value + " ");
                break;
            }
        }
    }
}