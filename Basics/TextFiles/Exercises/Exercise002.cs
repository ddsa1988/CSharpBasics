namespace Basics.TextFiles.Exercises;

public class Exercise002 {
    // Write a program that joins two text files and records the results in a third file.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string sourceFilePath1 =
            $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise002_File1.txt";
        string sourceFilePath2 =
            $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise002_File2.txt";
        string targetFilePath =
            $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise002_File3.txt";

        JoinFiles(sourceFilePath1, sourceFilePath2, targetFilePath);
    }

    private static void JoinFiles(string sourceFilePath1, string sourceFilePath2, string targetFilePath) {
        if (File.Exists(targetFilePath)) File.Delete(targetFilePath);

        WriteToFile(sourceFilePath1, targetFilePath);
        WriteToFile(sourceFilePath2, targetFilePath);
    }

    private static void WriteToFile(string sourceFilePath, string targetFilePath) {
        if (!File.Exists(sourceFilePath)) return;

        try {
            using StreamWriter writer = File.AppendText(targetFilePath);

            using var reader = new StreamReader(sourceFilePath);

            while (!reader.EndOfStream) {
                string? line = reader.ReadLine();

                if (string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line)) continue;

                writer.WriteLine(line);
            }
        } catch (IOException) {
            Console.Error.WriteLine($"Can't read file '{sourceFilePath}' and write file '{targetFilePath}'.");
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }
    }
}