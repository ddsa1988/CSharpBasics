namespace Basics.Expressions.Exercises;

public class Exercise001 {
    // Write an expression that checks whether an integer is odd or even.
    public static void UserMain() {
        int number;

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number > 0;

            if (!isNumberValid) continue;

            break;
        }

        bool isOdd = number % 2 != 0;
        string text = isOdd ? "odd" : "even";

        Console.WriteLine($"The number {number} is {text}.");
    }
}