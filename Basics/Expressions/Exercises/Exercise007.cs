namespace Basics.Expressions.Exercises;

public class Exercise007 {
    /*
        We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on
        the position p has the value of v. Example: n = 35, p = 5, v = 0 -> n = 3. Another example: n = 35, p = 2, v = 1 -> n = 39.
    */

    public static void UserMain() {
        const int posMinValue = 0;
        const int posMaxValue = 31;
        const int minValue = 0;
        const int maxValue = 1;

        int number, position, value;

        while (true) {
            Console.Write("Type a positive integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number);

            if (!isNumberValid) continue;

            break;
        }

        while (true) {
            Console.Write($"Type the bit position from {posMinValue} to {posMaxValue}: ");
            string? userInput = Console.ReadLine();

            bool isPositionValid = int.TryParse(userInput, out position);

            if (!isPositionValid) continue;

            break;
        }

        while (true) {
            Console.Write($"Type the value for the bit position ({minValue} or {maxValue}): ");
            string? userInput = Console.ReadLine();

            bool isValueValid = int.TryParse(userInput, out value);

            if (!isValueValid) continue;

            break;
        }

        int maskForOne = 1 << position;
        int maskForZero = ~(1 << position);

        int result = value == 1 ? number | maskForOne : number & maskForZero;

        string numberBinary = Convert.ToString(number, 2);
        string resultBinary = Convert.ToString(result, 2);

        string text =
            $"The number {number} (Binary {numberBinary}) with the value {value} at bit position {position} is {result} (Binary {resultBinary}).";

        Console.WriteLine(text);
    }
}