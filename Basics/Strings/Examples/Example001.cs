namespace Basics.Strings.Examples;

public class Example001 {
    public static void UserMain() {
        const string str1 = "Diego";
        const string str2 = "diego";
        const string str3 = "Diego";

        // Comparison for equality
        Console.WriteLine(str1.Equals(str2));
        Console.WriteLine(str1.Equals(str3));
        Console.WriteLine(str2.Equals(str2, StringComparison.CurrentCultureIgnoreCase));
        Console.WriteLine();

        // Comparison for alphabetical order
        Console.WriteLine(str1.CompareTo(str2));
        Console.WriteLine(str2.CompareTo(str1));
        Console.WriteLine(str1.CompareTo(str3));
        Console.WriteLine();

        Console.WriteLine(string.Compare(str1, str2, StringComparison.CurrentCultureIgnoreCase));
        Console.WriteLine(ReferenceEquals(str1, str3));
    }
}