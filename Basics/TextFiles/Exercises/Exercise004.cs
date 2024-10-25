namespace Basics.TextFiles.Exercises;

public class Exercise004 {
    // Write a program that compares two text files with the same number of rows
    // line by line and prints the number of equal and the number of different lines.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath1 = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise004_File1.txt";
        string filePath2 = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise004_File2.txt";

        PrintEqualLines(filePath1, filePath2);
    }

    private static void PrintEqualLines(string filePath1, string filePath2) {
        if (!File.Exists(filePath1) || !File.Exists(filePath2)) return;

        try {
            using var reader1 = new StreamReader(filePath1);
            using var reader2 = new StreamReader(filePath2);

            while (!reader1.EndOfStream && !reader2.EndOfStream) {
                string? line1 = reader1.ReadLine();
                string? line2 = reader2.ReadLine();

                Console.WriteLine($"Line 1 = {line1}");
                Console.WriteLine($"Line 2 = {line2}");
            }

        } catch (IOException) {
            Console.Error.WriteLine($"Can't read file '{filePath1}' and file '{filePath2}'.");
        } catch (Exception e) {
            Console.Error.WriteLine(e.ToString());
        }
    }
}