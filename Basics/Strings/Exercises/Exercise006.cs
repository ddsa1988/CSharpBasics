namespace Basics.Strings.Exercises;

public class Exercise006 {
    // Write a program that reads a string from the console (20 characters maximum) and 
    // if shorter complements it right with "*" to 20 characters.
    public static void UserMain() {
        const int maxLength = 20;
        const char specialChar = '*';
        string? userInput;

        while (true) {
            Console.Write($"Type something with the max length of {maxLength} characters: ");
            userInput = Console.ReadLine();

            if (!IsUserInputValid(userInput, maxLength)) continue;

            break;
        }

        string newString = ComplementString(userInput, maxLength, specialChar);

        Console.WriteLine("Original string: " + userInput);
        Console.WriteLine("New string: " + newString);
    }

    private static bool IsUserInputValid(string? input, int inputMaxLength) {
        return !(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input) || input.Length > inputMaxLength);
    }


    private static string ComplementString(string? text, int maxLength, char specialChar) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        if (maxLength <= 0) {
            throw new ArgumentOutOfRangeException(nameof(maxLength), "Value must be greater than zero");
        }

        if (char.IsWhiteSpace(specialChar)) {
            throw new ArgumentException("Value is empty", nameof(specialChar));
        }

        text = text.PadRight(maxLength, specialChar);

        return text;
    }
}