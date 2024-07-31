namespace Basics.Patterns;

public class ConstantPattern {
    public static void UserMain() {
        object obj = 3;

        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj.GetType() == typeof(int) && ((int)obj) == 3);
        Console.WriteLine(obj is int && ((int)obj) == 3);
        Console.WriteLine(obj is int n && n == 3);
        Console.WriteLine(obj is 3);
        Console.WriteLine(obj is 3.0);
    }
}