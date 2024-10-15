using System.Text;

namespace Basics.Strings.Exercises;

public class Exercise013 {
    // Write a program that reverses the words in a given sentence without changing punctuation and spaces. 
    // For example: "C# is not C++ and PHP is not Delphi" => "Delphi not is PHP and C++ not is C#".
    public static void UserMain() {
        string sample = "C# is not C++ and PHP is not Delphi";

        Console.WriteLine(ReverseWords(sample));
    }

    private static string ReverseWords(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        StringBuilder sb = new StringBuilder();
        string[] words = text.Split(" ");
        int length = words.Length;

        for (int i = length - 1; i >= 0; i--) {
            sb.Append(words[i] + " ");
        }

        return sb.ToString();
    }
}