namespace Basics.Delegates;

public class DelegatesBasics {
    public static void UserMain() {
        // Transformer t = new Transformer(Sum);
        Transformer t = Sum;
        Console.WriteLine(t(10));

        t = Power;
        Console.WriteLine(t(10));
    }

    private delegate int Transformer(int x);

    private static int Sum(int a) {
        return a + a;
    }

    private static int Power(int a) {
        return a * a;
    }
}