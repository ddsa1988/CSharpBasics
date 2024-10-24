namespace Basics.TextFiles.Examples;

public class Example001 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = @$"TextFiles{sepChar}Files{sepChar}ReadSample.txt";

        ReadFile(filePath);
    }

    private static void ReadFile(string filePath) {
        if (!File.Exists(filePath)) return;

        using StreamReader reader = new StreamReader(filePath);

        int lineNumber = 0;

        while (!reader.EndOfStream) {
            lineNumber++;
            string? line = reader.ReadLine();

            Console.WriteLine("Line {0} : {1}", lineNumber, line);
        }
    }
}