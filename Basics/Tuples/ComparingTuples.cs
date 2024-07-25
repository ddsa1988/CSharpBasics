namespace Basics.Tuples;

public class ComparingTuples {
    public static void UserMain() {
        {
            (string, int) bob1 = ("Bob", 16);
            (string, int) bob2 = ("Bob", 16);

            Console.WriteLine(bob1.Equals(bob2));
            Console.WriteLine(bob1 == bob2);
        }

        Console.WriteLine();

        {
            (string, int) bob1 = ("Bob", 17);
            (string, int) bob2 = ("Bob", 16);

            Console.WriteLine(bob1.Equals(bob2));
            Console.WriteLine(bob1 == bob2);
        }
    }
}