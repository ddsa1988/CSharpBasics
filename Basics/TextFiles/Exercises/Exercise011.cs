namespace Basics.TextFiles.Exercises;

public class Exercise011 {
    // Write a program that deletes all words that begin with the word "test".
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string sourceFilePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise011_File1.txt";
        string targetFilePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise011_File2.txt";
    }
}