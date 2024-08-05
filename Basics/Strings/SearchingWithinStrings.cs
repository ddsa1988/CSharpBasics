namespace Basics.Strings;

public class SearchingWithinStrings {
    public static void UserMain() {
        string str = "abcde abcde";
        StringComparison ignoreCase = StringComparison.InvariantCultureIgnoreCase;
        int startIndex = 3;

        Console.WriteLine(str.StartsWith("abC"));
        Console.WriteLine(str.StartsWith("abC", ignoreCase));
        Console.WriteLine();

        Console.WriteLine(str.EndsWith("DE"));
        Console.WriteLine(str.EndsWith("DE", ignoreCase));
        Console.WriteLine();

        Console.WriteLine(str.Contains("cD"));
        Console.WriteLine(str.Contains("cD", ignoreCase));
        Console.WriteLine();

        Console.WriteLine(str.IndexOf("E", startIndex));
        Console.WriteLine(str.IndexOf("E", startIndex, ignoreCase));
        Console.WriteLine();

        Console.WriteLine(str.LastIndexOf("E", startIndex));
        Console.WriteLine(str.LastIndexOf("E", ignoreCase));
        Console.WriteLine();
    }
}