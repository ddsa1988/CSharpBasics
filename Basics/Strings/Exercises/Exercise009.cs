using System.Text;

namespace Basics.Strings.Exercises;

public class Exercise009 {
    /*
        Write a program that extracts from a text all sentences that contain a particular word. We accept that the 
        sentences are separated from each other by the character "." and the words are separated from one another 
        by a character which is not a letter. 
        
        Sample text: We are living in a yellow submarine. We don't have anything else. Inside the submarine is
        very tight. So we are drinking all the day. We will move out of it in 5 days.
        
        Sample result: We are living in a yellow submarine. We will move out of it in 5 days.
    */
    public static void UserMain() {
        string sample = """
        We are living in a yellow submarine.  We don't have anything else. Inside the submarine is very tight. 
        So we are drinking all the day. We will move out of it in 5 days.
        """;

        string word = " in ";

        Console.WriteLine(ExtractAllSentences(sample, word));
    }

    private static string ExtractAllSentences(string text, string word) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        if (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word)) {
            throw new ArgumentException("Value is empty", nameof(word));
        }

        const char separator = '.';

        int startIndex = 0;
        int indexFound = text.IndexOf(separator, startIndex);

        StringBuilder sb = new StringBuilder();

        while (indexFound != -1) {
            string substring = text.Substring(startIndex, indexFound - startIndex + 1);

            bool IsWordFound = substring.Contains(word);

            if (IsWordFound) {
                sb.Append(substring.Trim() + " ");
            }

            startIndex = indexFound + 1;
            indexFound = text.IndexOf(separator, startIndex);
        }

        return sb.ToString();
    }
}