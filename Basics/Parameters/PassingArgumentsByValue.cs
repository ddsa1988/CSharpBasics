using System.Text;

namespace Basics.Parameters;

public class PassingArgumentsByValue {
    public static void MyMain() {
        StringBuilder sb = new StringBuilder();
        int x = 10;

        Function1(x);
        Function2(sb);

        Console.WriteLine($"Ouside the function => x = {x}");
        Console.WriteLine($"sb = {sb}");
    }

    private static void Function1(int a) {
        a++;
        Console.WriteLine($"Inside the function => a = {a}");
    }

    private static void Function2(StringBuilder funcSB) {
        funcSB.AppendLine("Test");
        funcSB = null;
    }
}