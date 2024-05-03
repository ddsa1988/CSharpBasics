using System.Xml.Serialization;

namespace Basics.Parameters;

public class RefReturns {
    private static string x = "Old value";

    private static ref string GetX() {
        return ref x;
    }

    public static void UserMain() {
        ref string xRef = ref GetX();

        Console.WriteLine("private static string x = Old value;\n");
        Console.WriteLine("private static ref string GetX() => ref x;\n");
        Console.WriteLine("ref string xRef = ref GetX();\n");
        Console.WriteLine("x = " + x);
        Console.WriteLine("xRef = " + xRef);
        Console.WriteLine();

        xRef = "New Value";
        Console.WriteLine("xRef = New Value;\n");
        Console.WriteLine("x = " + x);
        Console.WriteLine("xRef = " + xRef);
    }
}