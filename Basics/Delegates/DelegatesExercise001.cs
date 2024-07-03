namespace Basics.Delegates;

public class DelegatesExercise001 {
    public static void UserMain() {
        Transformer calculator = Sum;
        calculator += Sub;
        calculator += Mult;
        calculator += Div;

        calculator(10, 2);
    }

    private delegate void Transformer(int a, int b);

    private static void Sum(int x, int y) {
        int result = x + y;

        Console.WriteLine($"{x} + {y} = {result}");
    }

    private static void Sub(int x, int y) {
        int result = x - y;

        Console.WriteLine($"{x} - {y} = {result}");
    }

    private static void Mult(int x, int y) {
        int result = x * y;

        Console.WriteLine($"{x} * {y} = {result}");
    }

    private static void Div(int x, int y) {
        if (y == 0) return;

        int result = x / y;

        Console.WriteLine($"{x} / {y} = {result}");
    }
}