namespace Basics.NullableReferenceTypes;

public class NullableReferenceBasics {
    public static void UserMain() {
        string s1 = null;
        string? s2 = null;

        Console.WriteLine("s1 is " + (s1 ?? "null"));
        Console.WriteLine("s2 is " + (s2 ?? "null"));
    }
}