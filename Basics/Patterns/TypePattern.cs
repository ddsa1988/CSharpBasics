namespace Basics.Patterns;

public class TypePattern {
    public static void UserMain() {
        object obj = "Name";

        if (obj is string) Console.WriteLine(((string)obj).Length);

        if (obj is string str) Console.WriteLine(str.Length); //Pattern matching
    }
}