using Basics.Linq.Models;

namespace Basics.Linq.Examples;

public class Example001 {
    // Extension methods
    public static void UserMain() {
        string helloString = "Hello, Extension Methods!";
        int wordCount = helloString.WordCount();

        Console.WriteLine("'{0}' has {1} words.", helloString, wordCount);
        Console.WriteLine();

        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("[{0}]", string.Join(", ", numbers));

        numbers.IncreaseWith(5);
        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }
}