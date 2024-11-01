using System.Text;

namespace Basics.TextFiles.Exercises;

public class Exercise010 {
    // Write a program that extracts from an XML file the text only (without the tags).
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string sourceFilePath =
            $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise010_File1.txt";
        string targetFilePath =
            $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise010_File2.txt";

        string content = ReadFile(sourceFilePath);
        string newContent = ExtractTextFromXml(content);

        WriteFile(targetFilePath, newContent);
    }

    private static string ExtractTextFromXml(string content) {
        if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content)) return "";

        const char openTag = '<';
        const char closeTag = '>';

        var sb = new StringBuilder();
        var result = new List<string>();

        bool tagOpened = false;

        foreach (char value in content) {
            if (value == openTag && !tagOpened) {

                if (sb.Length > 0) {
                    result.Add(sb.ToString());
                    sb.Clear();
                }

                tagOpened = true;
                continue;
            }

            if (value == closeTag && tagOpened) {
                tagOpened = false;
                continue;
            }

            if (tagOpened || value == '\n') continue;

            sb.Append(value);
        }

        return string.Join("\n", result);
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
            Console.WriteLine(e.Message);
        }

        return sb.ToString();
    }
}