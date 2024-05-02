namespace Basics.Parameters;
public class PassingArgumentsWithRef {
    public static void UserMain() {
        Console.WriteLine("Passing arguments by reference (ref modifier):\n");

        int a = 10;
        string nameA = "Diego";
        string nameB = "Amanda";

        IncrementVariable(ref a);
        Console.WriteLine($"Outside the function => a = {a}");

        Console.WriteLine();

        Console.WriteLine($"Original names => Name A = {nameA}, Name B = {nameB}");
        Swap<string>(ref nameA, ref nameB);
        Console.WriteLine($"Swapped names => Name A = {nameA}, Name B = {nameB}");
    }

    private static void IncrementVariable(ref int a) {
        a++;
        Console.WriteLine($"Inside the function => a = {a}");
    }

    private static void Swap<T>(ref T a, ref T b) {
        (b, a) = (a, b);
    }
}
