namespace Basics.Strings.Examples;

public class Example002 {
    public static void UserMain() {
        string hel = "Hel";
        string hello = "Hello";
        string copy = hel + "lo";

        Console.WriteLine(hello == copy);
        Console.WriteLine(hello.Equals(copy));
        Console.WriteLine(Object.ReferenceEquals(hello, copy));
    }
}