namespace Basics.Strings.Examples;

public class Example002 {
    public static void UserMain() {
        const string hel = "Hel";
        const string hello = "Hello";
        const string copy = hel + "lo";

        Console.WriteLine(hello == copy);
        Console.WriteLine(hello.Equals(copy));
        Console.WriteLine(ReferenceEquals(hello, copy));
    }
}