namespace Basics.Expressions.Exercises;

public class Exercise005 {
    /*
        Write a program that takes as input a four-digit number in format abcd
        (e.g. 2011) and performs the following actions:
        - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        - Prints on the console the number in reversed order: dcba (in our example 1102).
        - Puts the last digit in the first position: dabc (in our example 1201).
        - Exchanges the second and the third digits: acbd (in our example 2101). 
    */

    public static void UserMain() {
        const int inputLength = 4;
        int number;

        while (true) {
            Console.Write("Type a positive four-digit integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number) && userInput.Length == inputLength;

            if (!isNumberValid) continue;

            break;
        }

        int a = number / 1000;
        int b = (number % 1000) / 100;
        int c = (number % 100) / 10;
        int d = number % 10;

        Console.WriteLine($"The sum of the digits is: {a + b + c + d}.");
        Console.WriteLine($"The number in reversed order is: {d}{c}{b}{a}.");
        Console.WriteLine($"The number with the last digit in the first position is: {d}{a}{b}{c}");
        Console.WriteLine($"The number with the second and the third digits exchanged is: {a}{c}{b}{d}");
    }
}