namespace Basics.Generics;

public class GenericMethods {
    public static void UserMain() {
        int n1 = 10;
        int n2 = 20;

        string s1 = "Diego";
        string s2 = "Amanda";

        Console.WriteLine($"Before swap: n1 => {n1}, n2 => {n2}");
        Console.WriteLine($"Before swap: s1 => {s1}, s2 => {s2}");
        Console.WriteLine();

        Swap<int>(ref n1, ref n2);
        Swap<string>(ref s1, ref s2);

        Console.WriteLine($"After swap: n1 => {n1}, n2 => {n2}");
        Console.WriteLine($"After swap: s1 => {s1}, s2 => {s2}");
    }

    private static void Swap<T>(ref T a, ref T b) {
        (a, b) = (b, a);
    }
}