namespace Basics.Numerics;

public class NumericLiterals() {
    public static void Literals() {
        const int x = 127; //Decimal notation
        //const int y = 0x7F; //Hexadecimal notation
        //const int z = 0b0111_1111; //Binary notation

        Console.WriteLine($"x => Decimal: {x}. Binary: {Convert.ToString(x, 2)}. Hexadecimal: {Convert.ToString(x, 16)}.");
    }
}
