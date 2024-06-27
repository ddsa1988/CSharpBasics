namespace Basics.Delegates;

public class DelegatesBasics {
    public static void UserMain() {
        // Transformer t = new Transformer(Sum);
        Transformer t = Sum;
        Console.WriteLine(t(10, 20));

        t = Power;
        Console.WriteLine(t(10, 2));
    }

    private delegate int Transformer(int x, int y);

    private static int Sum(int a, int b) {
        return a + b;
    }

    private static int Power(int a, int b) {
        int result = (int)Math.Pow(a, b);
        return result;
    }
}