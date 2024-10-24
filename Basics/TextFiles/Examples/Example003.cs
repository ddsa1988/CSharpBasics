namespace Basics.TextFiles.Examples;

public class Example003 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Example003.txt";
        string word = "C#";

        CountWordOccurrences(filePath, word);
    }

    private static void CountWordOccurrences(string filePath, string word) {
        if (!File.Exists(filePath)) return;

        int occurrences = 0;

        try {
            using StreamReader reader = new StreamReader(filePath);
            string? line = reader.ReadLine();
            StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase;

            while (line != null) {
                int index = line.IndexOf(word, stringComparison);

                while (index != -1) {
                    occurrences++;
                    index = line.IndexOf(word, index + 1, stringComparison);
                }

                line = reader.ReadLine();
            }

        } catch (IOException) {
            Console.Error.WriteLine("Cannot read file: '{0}'.", filePath);
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }

        Console.WriteLine($"The word '{word}' occurs {occurrences} times.");
    }
}