namespace Basics.Parameters;

public class PassingArgumentsByValue {
    public static void UserMain() {
        Console.WriteLine("Passing arguments by value:\n");

        StringBuilder sb = new StringBuilder();
        const int a = 10;

        IncrementVariable(a);
        Console.WriteLine($"Outside the function => a = {a}");

        Console.WriteLine();

        AppendText(sb);
        Console.WriteLine($"sb = {sb}");
    }

    private static void IncrementVariable(int a) {
        a++;
        Console.WriteLine($"Inside the function => a = {a}");
    }

    private static void AppendText(StringBuilder funcSb) {
        funcSb.AppendLine("Test");
        funcSb = null;
        Console.WriteLine("Inside the function StringBuilder was {0} after appending some text.", funcSb?.Length.ToString() ?? "NULL");
    }
}