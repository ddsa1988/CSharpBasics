namespace Basics.Strings.Exercises;

public class Exercise017 {
    // Write a program that reads a string from the console and prints in alphabetical order 
    // all letters from the input string and how many times each one of them occurs in the string.
    public static void UserMain() {
        string sample = "Diego dos Santos Alexandre";

        Dictionary<char, int> dict = CountTextLetters(sample);
        List<KeyValuePair<char, int>> dictOrdered = dict.OrderBy(x => x.Key).ToList();

        foreach (KeyValuePair<char, int> obj in dictOrdered) {
            Console.Write($"{obj.Key}:{obj.Value}, ");
        }

        Console.WriteLine();
    }

    private static Dictionary<char, int> CountTextLetters(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        var dict = new Dictionary<char, int>();

        foreach (char value in text) {
            if (char.IsWhiteSpace(value)) continue;

            if (dict.ContainsKey(value)) {
                dict[value] += 1;
            } else {
                dict[value] = 1;
            }
        }

        return dict;
    }
}