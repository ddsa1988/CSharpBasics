namespace Basics.Numerics;

public class RoundingErrors {
    public static void Errors() {
        const int maxCounter = 10;
        const float a = 0.1F;
        const decimal b = 0.1M;
        const double c = 1.0;
        const double d = 6.0;
        const decimal e = 1.0M;
        const decimal f = 6.0M;

        float g = 0.0F;
        decimal h = 0.0M;


        for (int i = 0; i < maxCounter; i++) {
            g += a;
            h += b;
        }

        Console.WriteLine(
            "Float and double works in base 2.\nDecimal works in base 10. Decimal can represent fraction numbers precisely.\n");

        Console.WriteLine($"float => a = {a}. Add 'a' {maxCounter} times = {g}");
        Console.WriteLine($"decimal => a = {a}. Add 'a' {maxCounter} times = {h}");
        Console.WriteLine();

        Console.WriteLine($"double => {c} / {d} = {c / d}");
        Console.WriteLine($"decimal => {e} / {f} = {e / f}");
    }
}