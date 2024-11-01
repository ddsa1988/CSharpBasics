namespace Basics.Strings.Exercises;

public class Exercise002 {
    // How many backslashes you must specify as an argument to the method Split(...) in order to split the text by a backslash?
    // Example: one\two\three.
    public static void UserMain() {
        const string sample = @"one\two\three";
        string[] words = sample.Split('\\');

        Console.WriteLine("Sample string: " + sample + '\n');

        Console.Write("Sample after split: ");

        foreach (string word in words) {
            Console.Write(word + " ");
        }

        Console.WriteLine();
    }
}