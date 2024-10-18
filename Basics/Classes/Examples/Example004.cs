using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace Basics.Classes.Examples;

public class Example004 {
    // Static fields
    public static void UserMain() {
        Console.WriteLine(StaticField.text);
        Console.WriteLine("A const field is also static: " + StaticField.PI);
    }

    private class StaticField {
        public static string text = "This is a static field";
        public const float PI = 3.14f;
    }
}