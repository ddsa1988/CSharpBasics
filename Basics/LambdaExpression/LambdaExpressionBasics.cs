namespace Basics.LambdaExpression;

public class LambdaExpressionBasics {
    public static void UserMain() {
        int n1 = 20;
        int n2 = 10;
        string s1 = "Diego";
        string s2 = "Amanda";

        Greeting("Lambda expression basics");
        Console.WriteLine($"{n1} + {n2} = {Sum(n1, n2)}");
        Console.WriteLine($"Strings total length = {TotalLength(s1, s2)}");
    }

    private static readonly Action<string> Greeting = msg => Console.WriteLine(msg);
    private static readonly Func<int, int, int> Sum = (x, y) => x + y;
    private static readonly Func<string, string, int> TotalLength = (s1, s2) => s1.Length + s2.Length;
}