namespace Basics.Tuples;

public class NamingTupleElements {
    public static void UserMain() {
        (string name, int age) bob = ("Bob", 18);
        Console.WriteLine(bob);
        Console.WriteLine(bob.name);
        Console.WriteLine(bob.age);

        Console.WriteLine();

        DateTime now = DateTime.Now;
        var time = (now.Day, now.Month, now.Year);
        Console.WriteLine(time.Day);
        Console.WriteLine(time.Month);
        Console.WriteLine(time.Year);
    }
}