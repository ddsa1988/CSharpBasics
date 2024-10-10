namespace Basics.ExceptionHandling.Exercises;

public class Exercise004 {
    // Write a method that reads the content of the file and prints it to the console. 
    // Find in MSDN how to us the System.IO.File.ReadAllText(...) method.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}Files{sepChar}Numbers.txt";

        Console.WriteLine(ReadTextFile(filePath));
    }

    private static string ReadTextFile(string filePath) {
        string text = "";

        if (!File.Exists(filePath)) return text;

        try {
            text = File.ReadAllText(filePath);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        return text;
    }
}