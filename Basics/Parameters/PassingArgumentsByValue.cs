using System.Text;

namespace Basics.Parameters;

public class PassingArgumentsByValue {
    public static void MyMain() {
        StringBuilder sb = new StringBuilder();
        const int a = 10;

        Function1(a);
        Console.WriteLine($"Outside the function => a = {a}");
        Console.WriteLine();
        
        Function2(sb);
        Console.WriteLine($"sb = {sb}");
    }

    private static void Function1(int a) {
        a++;
        Console.WriteLine($"Inside the function => a = {a}");
    }

    private static void Function2(StringBuilder funcSb) {
        funcSb.AppendLine("Test");
        funcSb = null;
        Console.WriteLine("Inside the function StringBuilder was {0} after appending some text.", funcSb?.Length.ToString() ?? "NULL");
    }
}