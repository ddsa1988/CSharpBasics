namespace Basics.Expressions;

public class Exercise004 {
    // Write an expression that checks whether the third bit in a given integer is 1 or 0.
    public static void UserMain() {
        const int mask = 8;
        int number;

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number > 0;

            if (!isNumberValid) continue;

            break;
        }

        int result = (number & mask) == mask ? 1 : 0;
        string numberBinary = Convert.ToString(number, 2);

        Console.WriteLine(
            $"The third bit from right to left of the number {number} (Binary {numberBinary}) is {result}.");
    }
}