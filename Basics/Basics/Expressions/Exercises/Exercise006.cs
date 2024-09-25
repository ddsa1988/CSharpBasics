namespace Basics.Expressions.Exercises;

public class Exercise006 {
    /*
        We are given a number n and a position p. Write a sequence of operations that prints the  value of the bit
        on the position p in the number (0 or 1). Example: n = 35, p = 5 -> 1. Another example: n = 35, p = 6 -> 0.
    */
    public static void UserMain() {
        const int posMinValue = 0;
        const int posMaxValue = 31;
        
        int number, position;

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && number > 0;

            if (!isNumberValid) continue;

            break;
        }

        while (true) {
            Console.Write("Type a positive integer number to check the bit position from {0} to {1}: ", posMinValue,
                posMaxValue);
            string? userInput = Console.ReadLine();

            bool isPositionValid = int.TryParse(userInput, out position) && position >= posMinValue &&
                                   position <= posMaxValue;

            if (!isPositionValid) continue;

            break;
        }

        int mask = 1 << position;
        int result = (number & mask) != 0 ? 1 : 0;
        string numberBinary = Convert.ToString(number, 2);

        Console.WriteLine(
            $"The number {number} (Binary {numberBinary}) on bit position {position} from right to left has the value of {result}.");
    }
}