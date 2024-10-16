namespace Basics.Strings.Exercises;

public class Exercise018 {
    // Write a program that reads a string from the console and prints in alphabetical order 
    // all words from the input string and how many times each one of them occurs in the string.
    public static void UserMain() {
        string sample = "Diego dos Santos dos Diego dos";

        Dictionary<string, int> dict = CountTextWords(sample);
        List<KeyValuePair<string, int>> dictOrdered = dict.OrderBy(x => x.Key).ToList();

        foreach (KeyValuePair<string, int> obj in dictOrdered) {
            Console.Write($"{obj.Key}:{obj.Value}, ");
        }

        Console.WriteLine();
    }

    private static Dictionary<string, int> CountTextWords(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        var dict = new Dictionary<string, int>();

        foreach (string value in text.Split(' ')) {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) continue;

            if (dict.ContainsKey(value)) {
                dict[value] += 1;
            } else {
                dict[value] = 1;
            }
        }

        return dict;
    }
}