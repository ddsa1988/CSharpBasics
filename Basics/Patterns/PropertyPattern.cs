namespace Basics.Patterns;

public class PropertyPattern {
    public static void UserMain() {
        object obj = "Something...";

        if (obj is string str && str.Length > 4) {
            Console.WriteLine($"Test1");
        }

        if (obj is string { Length: > 4 }) {
            Console.WriteLine("Test2");
        }
    }
}