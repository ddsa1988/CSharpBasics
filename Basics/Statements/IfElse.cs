namespace Basics.Statements;

public class IfElse {
    public static void UserMain() {
        string resultString;

        Console.Write("Type an integer number: ");
        string? userInput = Console.ReadLine();

        bool conversionResult = int.TryParse(userInput, out int number);

        if (!conversionResult) {
            Console.WriteLine("Invalid number!");
            return;
        }

        if (number % 2 == 0) {
            resultString = "even";
        } else {
            resultString = "odd";
        }

        Console.WriteLine($"The number {number} is {resultString}.");
    }
}