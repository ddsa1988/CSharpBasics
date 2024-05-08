namespace Basics.NullOperators;

public class NullConditionalOperator {
    public static void UserMain() {
        string? str1 = null;
        string? str2 = str1?.ToString().ToUpper();

        Console.WriteLine("string? str1 = null;");
        Console.WriteLine("string? str2 = str1?.ToString().ToUpper()\n");
        Console.WriteLine("str2 => " + (str2 ?? "null"));
    }
}