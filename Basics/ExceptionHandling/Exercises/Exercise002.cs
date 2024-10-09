namespace Basics.ExceptionHandling.Exercises;

using System.Text;

public class Exercise002 {
    // Write a method that takes as a parameter the name of a text file, reads the file and returns its content as string.
    // What should the method do if and exception is thrown?
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}Files{sepChar}Lorem Ipsum.txt";

        Console.WriteLine(Path.GetFullPath(filePath) + "\n");

        Console.WriteLine(ReadTextFile(filePath));

    }

    private static string ReadTextFile(string filePath) {
        StringBuilder sb = new StringBuilder();

        if (!File.Exists(filePath)) sb.ToString();

        try {
            using StreamReader sr = new StreamReader(filePath);

            while (!sr.EndOfStream) {
                string? line = sr.ReadLine();
                sb.Append(line);
            }
        } catch (Exception e) {
            Console.WriteLine($"File '{Path.GetFullPath(filePath)} could not be read.'");
            Console.WriteLine(e.Message);
        }

        return sb.ToString();
    }
}