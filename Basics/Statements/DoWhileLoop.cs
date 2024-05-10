namespace Basics.Statements;

public class DoWhileLoop {
    public static void UserMain() {
        Console.Write("Type a number from 0 up to 100: ");
        string? userInput = Console.ReadLine();

        bool isUserInputValid = int.TryParse(userInput, out int number);

        if (!isUserInputValid || number < 0) {
            Console.WriteLine("Invalid number!");
            return;
        }

        int counter = 0;

        do {
            Console.Write(counter + " ");

            counter++;
        } while (counter < number);
    }
}
