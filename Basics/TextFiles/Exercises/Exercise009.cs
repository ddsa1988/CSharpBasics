using System.Text;
using Console = System.Console;

namespace Basics.TextFiles.Exercises;

public class Exercise009 {
    // Write a program that deletes all the odd lines of a text file.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string sourceFilePath =
            $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise009_File1.txt";
        string targetFilePath =
            $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise009_File2.txt";

        string content = ReadFile(sourceFilePath);
        string replaceContent = DeleteOddLines(content);

        WriteFile(targetFilePath, replaceContent);
    }

    private static string DeleteOddLines(string content) {
        if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content)) return "";

        var sb = new StringBuilder();
        string[] lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        int countLines = 0;

        foreach (string line in lines) {
            countLines++;

            bool isEven = countLines % 2 == 0;

            if (isEven) continue;

            sb.Append(line + '\n');
        }

        return sb.ToString();
    }

    private static void WriteFile(string filePath, string content) {
        if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content)) return;

        if (File.Exists(filePath)) File.Delete(filePath);

        try {
            using StreamWriter writer = File.AppendText(filePath);

            string[] lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines) {
                writer.WriteLine(line);
            }
        } catch (IOException) {
            Console.Error.WriteLine($"Can't write file '{filePath}'.");
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }
    }

    private static string ReadFile(string filePath) {
        if (!File.Exists(filePath)) return "";

        var sb = new StringBuilder();

        try {
            using var reader = new StreamReader(filePath);

            while (!reader.EndOfStream) {
                string? line = reader.ReadLine();
                sb.Append(line + '\n');
            }
        } catch (IOException) {
            Console.Error.WriteLine($"Can't read file '{filePath}'.");
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }

        return sb.ToString();
    }
}