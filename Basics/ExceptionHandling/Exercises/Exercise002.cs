namespace Basics.ExceptionHandling.Exercises;

public class Exercise002 {
    // Write a method that takes as a parameter the name of a text file, reads the file and returns its content as string.
    // What should the method do if and exception is thrown?
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}Files{sepChar}Lorem Ipsum.txt";

        Console.WriteLine(sepChar);
        Console.WriteLine(Path.GetFullPath(filePath));
        Console.WriteLine(Path.Exists(filePath));
        Console.WriteLine(File.Exists(filePath));
    }
}