namespace Basics.LinearDataStructures.Exercises;

public class Exercise001 {
    // Write a program that reads from the console a sequence of positive integer numbers. The sequence ends when empty line is entered.
    // Calculate and print the sum and the average of the sequence. Keep the sequence in List<int>.
    public static void UserMain() {
        var numbers = new List<int>();

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput)) break;

            bool isNumberValid = int.TryParse(userInput, out int number);

            if (!isNumberValid || number < 0) continue;

            numbers.Add(number);
        }

        if (numbers.Count == 0) return;

        int sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine();
        Console.WriteLine("Numbers typed: {0}.", string.Join(", ", numbers));
        Console.WriteLine("Sum: {0}.", sum);
        Console.WriteLine("Average: {0}.", average);
    }
}