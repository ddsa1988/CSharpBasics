using System.Text.RegularExpressions;

namespace Basics.Loops.Exercises;

public partial class Exercise006 {
    // Write a program that converts a given number from binary to decimal notation.
    public static void UserMain() {
        string binary;

        while (true) {
            Console.Write("Type a binary number: ");
            string? userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput)) continue;

            if (!BinaryRegex().IsMatch(userInput)) continue;

            binary = userInput;
            break;
        }

        int size = binary.Length;
        double number = 0;

        for (int i = 0; i < size; i++) {
            double power = size - 1 - i;
            double bitValue = Math.Pow(2, power);

            if (binary[i] == '0') continue;

            number += bitValue;
        }

        Console.WriteLine(number);
    }

    [GeneratedRegex("^[01]+$")]
    private static partial Regex BinaryRegex();
}