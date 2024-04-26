namespace Basics.Numerics;

public class ArithmeticOperators {
    public static void Examples() {
        const int a = 20;
        const int b = 3;

        Console.WriteLine("{0} + {1} = {2}", a, b, ArithmeticOperators.Addition(a, b));
        Console.WriteLine("{0} - {1} = {2}", a, b, ArithmeticOperators.Subtraction(a, b));
        Console.WriteLine("{0} * {1} = {2}", a, b, ArithmeticOperators.Multiplication(a, b));
        Console.WriteLine("{0} / {1} = {2}", a, b, ArithmeticOperators.Division(a, b));
        Console.WriteLine("{0} % {1} = {2}", a, b, ArithmeticOperators.Remainder(a, b));
    }

    private static int Addition(int a, int b) {
        return a + b;
    }

    private static int Subtraction(int a, int b) {
        return a - b;
    }

    private static int Multiplication(int a, int b) {
        return a * b;
    }

    private static int Division(int a, int b) {
        if (b != 0) return a / b;
        
        Console.WriteLine("Impossible divide by zero.");
        return int.MinValue;
    }

    private static int Remainder(int a, int b) {
        if (b != 0) return a % b;
        
        Console.WriteLine("Impossible divide by zero.");
        return int.MinValue;
    }
}