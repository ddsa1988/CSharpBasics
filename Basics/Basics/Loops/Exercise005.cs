using System.Numerics;
using System.Text;

namespace Basics.Loops;

public class Exercise005 {
    // Write a program that converts a given number from decimal to binary notation (numeral system).
    public static void UserMain() {
        const int minValue = 0;
        const int maxValue = int.MaxValue;
        const int numberBits = 32;

        double number;

        while (true) {
            Console.Write($"Type a positive integer number from {minValue} to {maxValue}: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = double.TryParse(userInput, out number) && number >= minValue && number <= maxValue;

            if (!isNumberValid) continue;

            break;
        }

        StringBuilder sb = new StringBuilder();

        double auxNumber = number;

        for (int i = 0; i <= numberBits; i++) {
            double bitValue = Math.Pow(2, numberBits - i);

            if (auxNumber - bitValue >= 0) {
                auxNumber -= bitValue;
                sb.Append('1');
            } else {
                sb.Append('0');
            }
        }

        Console.WriteLine(sb.Length);

        for (int i = 0; i < sb.Length; i++) {
            if (sb[i] != '0') break;

            sb[i] = '\0';
        }

        Console.WriteLine(sb.Length);

        Console.WriteLine($"The number {number} in binary is {sb}.");
    }
}