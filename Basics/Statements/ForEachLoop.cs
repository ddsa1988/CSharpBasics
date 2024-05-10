namespace Basics.Statements;

public class ForEachLoop {
    public static void UserMain() {
        Console.Write("Type something: ");
        string? userInput = Console.ReadLine();

        bool isUserInputValid = !(string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput));

        if (!isUserInputValid) {
            Console.WriteLine("Invalid input!");
            return;
        }

        int counter = 0;

        userInput ??= "";

        foreach (char character in userInput) {
            counter++;
        }

        Console.WriteLine("You've typed a word with {0} characters.", counter);
    }
}