namespace Basics.Delegates;

public class DelegatesFunc {
    public static void UserMain() {
        int n1 = 20;
        int n2 = 10;

        Func<int, int, int>[] operations = [Sum, Sub, Mult, Div];

        Func<int, int, int> calculator = operations[0];
        Console.WriteLine(calculator(n1, n2));

        calculator = operations[1];
        Console.WriteLine(calculator(n1, n2));

        calculator = operations[2];
        Console.WriteLine(calculator(n1, n2));

        calculator = operations[3];
        Console.WriteLine(calculator(n1, n2));
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
        if (b == 0) {
            Console.WriteLine("Impossible divide by zero.");
            return 0;
        }

        return a / b;
    }
}