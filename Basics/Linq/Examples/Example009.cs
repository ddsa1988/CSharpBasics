namespace Basics.Linq.Examples;

public class Example009 {
    // Sorting data with Linq
    public static void UserMain() {
        string[] names = { "Diego", "Amanda", "Ana", "Joana", "Alexandre" };

        IEnumerable<string> namesSortedByLength = from name in names orderby name.Length descending select name;

        Console.WriteLine("Names sorted by length:\n" + string.Join("\n", namesSortedByLength));
    }
}