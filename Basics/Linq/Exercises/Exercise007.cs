using System.Text;

namespace Basics.Linq.Exercises;

public class Exercise007 {
    // Write an extension method for the class String that capitalizes all letters,
    // which are the beginning of a word in a sentence in English.
    // For example: "this iS a Sample sentence." should be converted to "This Is A Sample Sentence.".
    public static void UserMain() {
        const string sample1 = "this iS a Sample sentence.";
        const string sample2 = "dIEGO";

        Console.WriteLine(sample1.Capitalize());
        Console.WriteLine(sample2.Capitalize());
        Console.WriteLine("".Capitalize());
    }
}

public static class StringExtension {
    public static string Capitalize(this string str) {
        var sb = new StringBuilder();

        if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str)) return sb.ToString();

        if (!str.Contains(' ')) return str[0].ToString().ToUpper() + str.Substring(1).ToLower();

        string[] words = str.Split(' ');

        foreach (string word in words) {
            sb.Append(word[0].ToString().ToUpper() + word.Substring(1).ToLower() + " ");
        }

        return sb.ToString();
    }
}