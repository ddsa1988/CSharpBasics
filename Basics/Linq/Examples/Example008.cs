namespace Basics.Linq.Examples;

public class Example008 {
    // Results of Linq queries
    public static void UserMain() {
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

        IEnumerable<int> evenNumbers = from num in numbers where num % 2 == 0 select num;

        Console.WriteLine("Even numbers: {0}.", string.Join(", ", evenNumbers));
    }
}