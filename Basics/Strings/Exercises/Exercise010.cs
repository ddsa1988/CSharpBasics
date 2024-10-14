namespace Basics.Strings.Exercises;

public class Exercise010 {
    /*
        A string is given, composed of several "forbidden" words separated by commas. Also a text is given, 
        containing those words. Write a program that replaces the forbidden words with asterisks. 
        
        Sample text:
        Microsoft announced its next generation C# compiler today.
        It uses advanced parser and special optimizer for the Microsoft CLR.
        
        Sample string containing the forbidden words: "C#,CLR,Microsoft".
        
        Sample result:
        ********* announced its next generation ** compiler today.
        It uses advanced parser and special optimizer for the ********* ***.
    */
    public static void UserMain() {
        string sample = """
        Microsoft announced its next generation C# compiler today.
        It uses advanced parser and special optimizer for the Microsoft CLR.
        """;

        string forbiddenWords = "C#,CLR,Microsoft";

        string[] words = GetArrayOfWords(forbiddenWords);
        string newText = ReplaceTextWords(sample, words);

        Console.WriteLine("Original text => " + sample + '\n');
        Console.WriteLine("New text => " + newText);
    }

    private static string ReplaceTextWords(string text, string[] words) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        if (words == null || words.Length == 0) {
            throw new ArgumentException("Value is empty", nameof(words));
        }

        const char newChar = '*';
        string newText = text;

        foreach (string word in words) {
            string newWord = "".PadLeft(word.Length, newChar);
            newText = newText.Replace(word, newWord);
        }

        return newText;
    }

    private static string[] GetArrayOfWords(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        char separator = ',';

        string[] words = text.Split(separator);

        return words;
    }
}