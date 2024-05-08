namespace Basics.NullOperators;

public class NullCoalescingOperator {
    public static void UserMain() {
        string? str1 = null;
        string? str2 = "Diego";

        string str3 = str1 ?? "Some value";
        string str4 = str2 ?? "Some value";

        Console.WriteLine("string? str1 = null;");
        Console.WriteLine("string str3 = str1 ?? \"Some value\";\n");
        Console.WriteLine("str3 => " + str3);

        Console.WriteLine();

        Console.WriteLine("string? str2 = \"Diego\";");
        Console.WriteLine("string str4 = str2 ?? \"Some value\";\n");
        Console.WriteLine("str4 => " + str4);
    }
}