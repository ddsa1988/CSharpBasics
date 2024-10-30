using System.Text;
using System.Text.RegularExpressions;

namespace Basics.TextFiles.Exercises;

public class Exercise007 {
    // Write a program that replaces every occurrence of the substring "start" with "finish" in a text file.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string sourceFilePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise007_File1.txt";
        string targetFilePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise007_File2.txt";

        const string oldWord = "start";
        const string newWord = "finish";

        string content = ReadFile(sourceFilePath);
        string replacedContent = ReplaceWord(content, oldWord, newWord);

        WriteFile(targetFilePath, replacedContent);
    }

    private static string ReplaceWord(string content, string oldWord, string newWord) {
        if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content)) {
            throw new ArgumentException("Parameter is empty or null.", nameof(content));
        }

        string pattern = $"{oldWord}";

        string replacedContent = Regex.Replace(content, pattern, newWord, RegexOptions.IgnoreCase);

        return replacedContent;
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