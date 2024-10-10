namespace Basics.ExceptionHandling.Exercises;

using System.Text;
using Basics.ExceptionHandling.Models;

public class Exercise003 {
    // Search for information in Internet and define your own class for exception FileParseException.
    // The exception has to contain the name of the processed file and the number of the row where the problem is occurred.
    // Add appropriate constructors in the exception. Write a program that reads integers from a text file. 
    // If the during reading a row does not contain an integer throw FileParseException and pass it to the calling method..
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}Files{sepChar}Numbers.txt";

        Console.WriteLine(ReadTextFile(filePath));
    }

    private static string ReadTextFile(string filePath) {
        StringBuilder sb = new StringBuilder();
        int counter = 1;

        if (!File.Exists(filePath)) return sb.ToString();

        try {
            using StreamReader sr = new StreamReader(filePath);

            while (!sr.EndOfStream) {
                string? line = sr.ReadLine();

                bool isNumberValid = int.TryParse(line, out int number);

                if (!isNumberValid) throw new FileParseException($"File '{filePath}' does not contain an integer at line {counter}.");

                sb.Append(number + " ");
                counter++;
            }

        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        return sb.ToString();
    }
}