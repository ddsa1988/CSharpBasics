namespace Basics.Tuples;

public class TuplesBasics {
    public static void UserMain() {
        (string, int) bob = ("Bob", 18);

        Console.WriteLine(bob);
        Console.WriteLine(bob.Item1);
        Console.WriteLine(bob.Item2);

        Console.WriteLine();
        
        (string, int) p = GetPerson();
        Console.WriteLine(p);
    }

    private static (string, int) GetPerson() => ("Person", 23);
}