using System.Text;

namespace Basics.Strings.Exercises;

public class Exercise001 {
    // Write a program that reads a string, reverse it and prints it to the console. For example: "introduction" => "noitcudortni".
    public static void UserMain() {
        string sample1 = "introduction";
        string sample2 = "diego";

        Console.WriteLine(ReverseString(sample1));
        Console.WriteLine(ReverseString(sample2));
    }

    private static string ReverseString(string source) {
        StringBuilder sb = new StringBuilder();
        int length = source.Length;

        for (int i = length - 1; i >= 0; i--) {
            sb.Append(source[i]);
        }

        return sb.ToString();
    }
}