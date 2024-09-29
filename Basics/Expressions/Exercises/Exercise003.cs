namespace Basics.Expressions.Exercises;

public class Exercise003 {
    // Write an expression that looks for a given integer if its third digit (right to left) is 7.
    public static void UserMain() {
        const int matchNumber = 7;
        int number;

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number > 0;

            if (!isNumberValid) continue;

            break;
        }

        bool isNumberMatch = ((number / 100) % 10) == matchNumber;
        string text = isNumberMatch ? "is" : "isn't";

        Console.WriteLine($"The third digit from right to left of the number {number} {text} {matchNumber}.");
    }
}