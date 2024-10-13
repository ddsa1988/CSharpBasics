namespace Basics.Strings.Exercises;

public class Exercise007 {
    // Write a program that converts a given string into the form of array of Unicode escape sequences in the format used in the C# language.
    // Sample input: "Test". Result: "\u0054\u0065\u0073\u0074".
    public static void UserMain() {
        string sample = "Test";

        string[] unicodeSequence = GetUnicodeSequence(sample);

        foreach (string unicode in unicodeSequence) {
            Console.Write(unicode);
        }

        Console.WriteLine();
    }

    private static string[] GetUnicodeSequence(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        const string unicodeSpecialChar = @"\u";

        int length = text.Length;
        string[] unicodeSequence = new string[length];

        for (int i = 0; i < length; i++) {
            int charValue = (int)text[i];
            string unicode = $"{unicodeSpecialChar}{charValue:X4}";

            unicodeSequence[i] = unicode;
        }

        return unicodeSequence;
    }
}