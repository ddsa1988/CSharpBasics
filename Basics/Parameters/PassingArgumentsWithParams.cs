namespace Basics.Parameters;
public class PassingArgumentsWithParams {
    public static void UserMain() {
        Console.WriteLine("Passing arguments by reference (params modifier):\n");
        Console.WriteLine(@"The params modifier, if applied to the last parameter of a method, allows the
method to accept any number of arguments of a particular type. The parameter
type must be declared as an (single-dimensional) array." + "\n");

        const int a = 10;
        const int b = 20;
        const int c = 30;

        Console.WriteLine($"Sum() = {Sum()}");
        Console.WriteLine($"Sum({a}) = {Sum(a)}");
        Console.WriteLine($"Sum({a},{b}) = {Sum(a, b)}");
        Console.WriteLine($"Sum({a},{b},{c}) = {Sum(a, b, c)}");
    }

    private static double Sum(params double[] numbers) {
        if (numbers.Length == 0) return default(double);

        double sum = 0;

        foreach (double number in numbers) {
            sum += number;
        }
        return sum;
    }
}
