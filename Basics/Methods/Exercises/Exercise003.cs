namespace Basics.Methods.Exercises;

public class Exercise003 {
    // Write a method that returns the English name of the last digit of a given number. 
    // Example: for 512 prints "two"; for 1024 prints "four".
    public static void UserMain() {
        int number;

        while (true) {
            Console.Write("Type an integer number: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out number);

            if (!isNumberValid) continue;

            break;
        }

        Console.WriteLine($"The last digit name of {number} is '{GetLastDigitName(number)}'.");
    }

    private static int GetLastDigit(int number) {
        return number % 10;
    }

    private static string GetLastDigitName(int number) {
        int digit = Math.Abs(GetLastDigit(number));

        return digit switch {
            0 => "zero",
            1 => "one",
            2 => "two",
            3 => "three",
            4 => "four",
            5 => "five",
            6 => "six",
            7 => "seven",
            8 => "eight",
            9 => "nine",
            _ => "",
        };
    }
}