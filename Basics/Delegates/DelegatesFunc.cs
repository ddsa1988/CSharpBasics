namespace Basics.Delegates;

public class DelegatesFunc {
    public static void UserMain() {
        Func<int, int, int>[] operations = [Sum, Sub, Mult, Div];

        Func<int, int, int> calculator = operations[0];
        Console.WriteLine(calculator(20, 10));

        calculator = operations[1];
        Console.WriteLine(calculator(20, 10));

        calculator = operations[2];
        Console.WriteLine(calculator(20, 10));

        calculator = operations[3];
        Console.WriteLine(calculator(20, 10));
    }

    private static int Sum(int a, int b) {
        return a + b;
    }

    private static int Sub(int a, int b) {
        return a - b;
    }

    private static int Mult(int a, int b) {
        return a * b;
    }

    private static int Div(int a, int b) {
        if (b == 0) return 0;

        return a / b;
    }
}