namespace Basics.TextFiles.Exercises;

public class Exercise001 {
    // Write a program that reads a text file and prints its odd lines on the console.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise001.txt";

        PrintOddLines(filePath);
    }

    private static void PrintOddLines(string filePath) {
        if (!File.Exists(filePath)) return;

        try {
            using StreamReader reader = new StreamReader(filePath);
            int countLines = 0;

            while (!reader.EndOfStream) {
                string? line = reader.ReadLine();
                countLines++;

                bool isOddLine = (countLines % 2) != 0;

                if (!isOddLine) continue;

                if (string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line)) continue;

                Console.WriteLine("Line: {0}, Text: {1}", countLines, line);
            }

        } catch (IOException) {
            Console.Error.WriteLine("Cannot read the file '{0}'.", filePath);
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }
    }
}