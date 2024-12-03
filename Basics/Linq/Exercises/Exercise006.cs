namespace Basics.Linq.Exercises;

public class Exercise006 {
    // Write a program that prints to the console all numbers from a given array (or list),
    // that are multiples of 7 and 3 at the same time. Use the built-in extension methods
    // with lambda expressions and then rewrite the same using a LINQ query.
    public static void UserMain() {
        const int multiple = 21;
        int[] numbers = [1, 2, 3, 21, 4, 5, 6, 7, 42, 8, 9, 10];

        IEnumerable<int> result1 = numbers.Where(x => x % multiple == 0);
        Console.WriteLine("[{0}]", string.Join(", ", result1));
        Console.WriteLine();

        IEnumerable<int> result2 =
            from number in numbers
            where number % multiple == 0
            select number;
        
        Console.WriteLine("[{0}]", string.Join(", ", result2));
    }
}