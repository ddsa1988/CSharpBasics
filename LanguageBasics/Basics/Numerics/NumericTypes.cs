namespace Basics.Numerics;

public class NumericTypes {
    public static void SignedIntegers() {

        Console.WriteLine("Signed integer type\n");
        Console.WriteLine("sbyte => Type of {0}. Size of {1} byte. From {2} to {3}.", typeof(sbyte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("short => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(short), sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("int => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(int), sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("long => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(long), sizeof(long), long.MinValue, long.MaxValue);
    }

    public static void UnsignedIntegers() {

        Console.WriteLine("Unsigned integer type\n");
        Console.WriteLine("byte => Type of {0}. Size of {1} byte. From {2} to {3}.", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("ushort => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(ushort), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("uint => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(uint), sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("ulong => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(ulong), sizeof(ulong), ulong.MinValue, ulong.MaxValue);
    }

    public static void Real() {

        Console.WriteLine("Real type\n");
        Console.WriteLine("float => Type of {0}. Size of {1} byte. From {2} to {3}.", typeof(float), sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("double => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(double), sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("decimal => Type of {0}. Size of {1} bytes. From {2} to {3}.", typeof(decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
}
