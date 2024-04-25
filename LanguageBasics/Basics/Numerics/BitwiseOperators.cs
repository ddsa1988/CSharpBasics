namespace Basics.Numerics;

public class BitwiseOperators {
    public static void Complement() {
        byte a = 0b1001_0110;
        byte b = (byte)~a;

        Console.WriteLine("COMPLEMENT => ~ {0} = {1}", Convert.ToString(a, 2), Convert.ToString(b, 2));
    }

    public static void And() {
        const byte a = 0b1100_1100;
        const byte b = 0b1010_0110;
        const byte c = (byte)(a & b);

        Console.WriteLine("AND => {0} & {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(c, 2));
    }

    public static void Or() {
        const byte a = 0b1100_1100;
        const byte b = 0b1010_0110;
        const byte c = (byte)(a | b);

        Console.WriteLine("OR => {0} | {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(c, 2));
    }

    public static void OrExclusive() {
        const byte a = 0b1100_1100;
        const byte b = 0b1010_0110;
        const byte c = (byte)(a ^ b);

        Console.WriteLine("OR EXCLUSIVE => {0} ^ {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(c, 2));
    }

    public static void ShiftLeft() {
        const byte places = 1;
        const byte a = 0b0100_1001;
        const byte b = (byte)(a << places);

        Console.WriteLine("{0} << {1} = {2} ", Convert.ToString(a, 2), places, Convert.ToString(b, 2));
    }

    public static void ShiftRight() {
        const byte places = 1;
        const byte a = 0b0100_1001;
        const byte b = (byte)(a >> places);

        Console.WriteLine("{0} >> {1} = {2} ", Convert.ToString(a, 2), places, Convert.ToString(b, 2));
    }
}
