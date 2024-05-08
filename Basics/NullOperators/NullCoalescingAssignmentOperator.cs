namespace Basics.NullOperators;

public class NullCoalescingAssignmentOperator {
    public static void UserMain() {
        string? str1 = null;
        string? str2 = "Diego";

        str1 ??= "Some value";
        str2 ??= "Some value";

        Console.WriteLine("string? str1 = null;");
        Console.WriteLine("str1 ??= \"Some value\";\n");
        Console.WriteLine("str1 => " + str1);

        Console.WriteLine();

        Console.WriteLine("string? str2 = \"Diego\";");
        Console.WriteLine("str2 ??= \"Some value\";\n");
        Console.WriteLine("str2 => " + str2);

    }
}