namespace Basics.Numerics;

public class NumericConversions {
    public static void Conversions() {

        int a = int.MaxValue / 2;
        long b = a; //Implicit conversion
        short c = (short)a; //Explicit conversion
        float d = a;
        int e = (int)d;

        Console.WriteLine($"{a.GetType()} => a = {a}");
        Console.WriteLine($"a converted to {b.GetType()} => b = {b}");
        Console.WriteLine($"a converted to {c.GetType()} => c = {c}");
        Console.WriteLine($"a converted to {d.GetType()} => d = {d}");
        Console.WriteLine($"d converted to {e.GetType()} => e = {e}");
    }
}
