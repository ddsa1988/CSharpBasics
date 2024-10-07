namespace Basics.Recursion.Examples;

public class Example002 {
    // Write a method for finding the Factorial number.
    public static void UserMain() {
        Console.WriteLine(FactorialLoop(8));

        Console.WriteLine(FactorialRecursion(5));
    }

    private static decimal FactorialRecursion(int number) {
        if (number <= 0) return 1;

        return number * FactorialRecursion(number - 1);
    }

    private static decimal FactorialLoop(int number) {
        decimal factorial = 1;

        for (int i = 1; i <= number; i++) {
            factorial *= i;
        }

        return factorial;
    }
}