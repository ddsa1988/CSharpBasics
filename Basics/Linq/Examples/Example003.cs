namespace Basics.Linq.Examples;

public class Example003 {
    // Lambda expressions
    public static void UserMain() {
        var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
        
        Console.WriteLine("Numbers: [{0}].", string.Join(", ", numbers));
        Console.WriteLine("Even numbers: [{0}].", string.Join(", ", evenNumbers));
    }
}