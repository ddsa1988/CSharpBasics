namespace Basics.Expressions;

public class Exercise002 {
    // Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
    public static void UserMain() {
        const int divisibleBy = 35;
        int number;

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number > 0;

            if (!isNumberValid) continue;

            break;
        }

        bool isNumberDivisible = number % divisibleBy == 0;
        string text = isNumberDivisible ? "is" : "isn't";

        Console.WriteLine($"The number {number} {text} divisible by {divisibleBy}.");
    }
}