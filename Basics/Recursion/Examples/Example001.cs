namespace Basics.Recursion.Examples;

public class Example001 {
    // Write a method for finding the Fibonacci number.
    // Fibonacci formula => F1 = F2 = 1; Fn = Fn-1 + Fn-2 for n > 2.
    // Fibonacci sequence: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
    public static void UserMain() {
        Console.WriteLine(FibonacciLoop(12));

        Console.WriteLine(FibonacciRecursion(10));
    }

    private static decimal FibonacciRecursion(int number) {
        if (number < 0) return 0;

        if (number <= 2) return 1;

        return FibonacciRecursion(number - 1) + FibonacciRecursion(number - 2);
    }


    private static decimal FibonacciLoop(int number) {
        decimal previous = 0;
        decimal actual = 1;

        if (number <= 0) return previous;

        if (number <= 2) return actual;

        for (int i = 1; i < number; i++) {
            decimal temp = actual;

            actual += previous;
            previous = temp;
        }

        return actual;
    }
}