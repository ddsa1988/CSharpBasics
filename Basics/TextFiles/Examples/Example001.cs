namespace Basics.TextFiles.Examples;

public class Example001 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Example001.txt";

        ReadFile(filePath);
    }

    private static void ReadFile(string filePath) {
        if (!File.Exists(filePath)) return;

        try {
            using var reader = new StreamReader(filePath);

            int lineNumber = 0;

            while (!reader.EndOfStream) {
                lineNumber++;
                string? line = reader.ReadLine();

                Console.WriteLine("Line {0} : {1}", lineNumber, line);
            }

        } catch (FileNotFoundException) {
            Console.Error.WriteLine("File not found: '{0}'.", filePath);
        } catch (DirectoryNotFoundException) {
            Console.Error.WriteLine("Directory not found: '{0}'.", filePath);
        } catch (IOException) {
            Console.Error.WriteLine("Cannot read file: '{0}'.", filePath);
        }
    }
}