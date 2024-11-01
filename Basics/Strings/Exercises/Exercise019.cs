using System.Text;

namespace Basics.Strings.Exercises;

public class Exercise019 {
    // Write a program that reads a string from the console and replaces every sequence of identical
    // letters in it with a single letter (the repeating letter). Example: "aaaaabbbbbcdddeeeedssaa" => "abcdedsa".
    public static void UserMain() {
        const string sample = "aaaaabbbbbcdddeeeedssaa";

        Console.WriteLine(GetSingleLetters(sample));
    }

    private static string GetSingleLetters(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        var sb = new StringBuilder();
        char lastChar = '\0';

        foreach (char value in text) {
            if (value == lastChar) continue;

            sb.Append(value);
            lastChar = value;
        }

        return sb.ToString();
    }
}