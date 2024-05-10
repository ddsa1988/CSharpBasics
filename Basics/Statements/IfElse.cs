namespace Basics.Statements;

public class IfElse {
    public static void UserMain() {
        Console.Write("Type an integer number: ");
        string? userInput = Console.ReadLine();

        bool isUserInputValid = int.TryParse(userInput, out int number);

        if (!isUserInputValid) {
            Console.WriteLine("Invalid number!");
            return;
        }

        string resultString = number % 2 == 0 ? "even" : "odd";

        Console.WriteLine($"The number {number} is {resultString}.");
    }
}