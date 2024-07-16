namespace Basics.Delegates;

public class DelegatesAction {
    public static void UserMain() {
        int n1 = 20;
        int n2 = 10;

        Action<int, int>[] operations = [PrintSum, PrintSub, PrintMult, PrintDiv];

        Action<int, int> printOperations = operations[0];
        printOperations(n1, n2);

        printOperations = operations[1];
        printOperations(n1, n2);

        printOperations = operations[2];
        printOperations(n1, n2);

        printOperations = operations[3];
        printOperations(n1, n2);
    }

    private static void PrintSum(int a, int b) {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    private static void PrintSub(int a, int b) {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    private static void PrintMult(int a, int b) {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    private static void PrintDiv(int a, int b) {
        if (b == 0) {
            Console.WriteLine("Impossible divide by zero.");
            return;
        };

        Console.WriteLine($"{a} / {b} = {a / b}");
    }
}