namespace Basics.Parameters;

public class OptionalParameters {
    public static void UserMain() {
        const int x = 10;
        const int y = 20;
        const int z = 30;

        Console.WriteLine(Sum());
        Console.WriteLine(Sum(x));
        Console.WriteLine(Sum(x, y));
        Console.WriteLine(Sum(x, y, z));

        Console.WriteLine();

        Console.WriteLine(Sum(a: x));
        Console.WriteLine(Sum(b: y));
        Console.WriteLine(Sum(c: z));
        Console.WriteLine(Sum(a: x, b: y));
        Console.WriteLine(Sum(a: x, c: z));
        Console.WriteLine(Sum(b: y, c: z));
        Console.WriteLine(Sum(a: x, b: y, c: z));
    }

    private static int Sum(int a = 0, int b = 0, int c = 0) {
        return a + b + c;
    }
}