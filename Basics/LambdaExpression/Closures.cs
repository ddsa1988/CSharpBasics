namespace Basics.LambdaExpression;

public class Closures {
    public static void UserMain() {
        Func<int> c1 = Counter();

        Console.WriteLine(c1());
        Console.WriteLine(c1());
        Console.WriteLine(c1());
    }

    private static Func<int> Counter() {
        int counter = 0;
        return () => counter++;
    }
}