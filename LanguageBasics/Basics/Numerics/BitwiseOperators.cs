namespace Basics.Numerics;

public class BitwiseOperators {
    public static void Complement() {
        byte a = 0b1001_0110;
        byte b = (byte)~a;

        Console.WriteLine("COMPLEMENT => ~ {0} = {1}", Convert.ToString(a, 2), Convert.ToString(b, 2));
    }

    public static void And() {
        byte a = 0b1100_1100;
        byte b = 0b1010_0110;
        byte c = (byte)(a & b);

        Console.WriteLine("AND => {0} & {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(c, 2));
    }

    public static void Or() {
        byte a = 0b1100_1100;
        byte b = 0b1010_0110;
        byte c = (byte)(a | b);

        Console.WriteLine("OR => {0} | {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(c, 2));
    }

    public static void OrExclusive() {
        byte a = 0b1100_1100;
        byte b = 0b1010_0110;
        byte c = (byte)(a ^ b);

        Console.WriteLine("OR EXCLUSIVE => {0} ^ {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(c, 2));
    }

    public static void ShiftLeft() {
        byte places = 1;
        byte a = 0b0100_1001;
        byte b = (byte)(a << places);

        Console.WriteLine("{0} << {1} = {2} ", Convert.ToString(a, 2), places, Convert.ToString(b, 2));
    }

    public static void ShiftRight() {
        byte places = 1;
        byte a = 0b0100_1001;
        byte b = (byte)(a >> places);

        Console.WriteLine("{0} >> {1} = {2} ", Convert.ToString(a, 2), places, Convert.ToString(b, 2));
    }
}
