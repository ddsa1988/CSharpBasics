namespace Basics.Strings.Exercises;

public class Exercise004 {
    /* 
        Write a program that detects how many times a substring is contained in the text. 
        For example, let’s look for the substring "in" in the text:

        We are living in a yellow submarine. We don't have anything
        else. Inside the submarine is very tight. So we are drinking
        all the day. We will move out of it in 5 days.

        The result is 9 occurrences.
    */
    public static void UserMain() {
        const string sample = """
        We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
        So we are drinking all the day. We will move out of it in 5 days.
        """;

        const string substring = "in";

        Console.WriteLine(CountOccurrences(sample, substring));
    }

    private static int CountOccurrences(string text, string substring) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        if (string.IsNullOrEmpty(substring) || string.IsNullOrWhiteSpace(substring)) {
            throw new ArgumentException("Value is empty", nameof(substring));
        }

        string auxText = text.ToLower().Trim();
        string auxSubstring = substring.ToLower().Trim();

        int counter = 0;
        int index = auxText.IndexOf(auxSubstring, 0, StringComparison.InvariantCultureIgnoreCase);

        while (index != -1) {
            counter++;
            index = auxText.IndexOf(auxSubstring, index + 1, StringComparison.InvariantCultureIgnoreCase);
        }

        return counter;
    }
}