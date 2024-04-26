namespace Basics.Numerics;

public class SpecialValues {
    public static void Values() {
        const float a = 1.0F;
        const float b = -1.0F;
        const float c = 0.0F;

        const float d = a / c;
        const float e = b / c;
        const float f = c / c;

        Console.WriteLine($"{a:F1} / {c:F1} = {d} => Infinity");
        Console.WriteLine($"{b:F1} / {c:F1} = {e} => -Infinity");
        Console.WriteLine($"{c:F1} / {c:F1} = {f} => Not a number");

        Console.WriteLine(
            $"{f} == {float.NaN} = {f == float.NaN} => Using equals, a NaN value is never equal to another value");
        Console.WriteLine($"float.IsNaN({f}) = {float.IsNaN(f)}");
        Console.WriteLine($"object.Equals({f}, float.NaN)) = {object.Equals(f, float.NaN)}");
    }
}