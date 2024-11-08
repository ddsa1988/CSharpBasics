namespace Basics.LinearDataStructures.Exercises;

public class Exercise003 {
    // Write a program that reads from the console a sequence of positive integer numbers.
    // The sequence ends when an empty line is entered. Print the sequence sorted in ascending order.
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

        Console.WriteLine("Numbers typed: {0}.", string.Join(", ", numbers));

        numbers.Sort();

        Console.WriteLine("Numbers sorted {0}.", string.Join(", ", numbers));
    }
}