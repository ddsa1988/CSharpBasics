namespace Basics.Linq.Examples;

public class Example007 {
    // Statements in lambda expressions
    public static void UserMain() {
        var numbers = new List<int> { 20, 1, 4, 8, 9, 44 };

        List<int> evenNumbers = numbers.FindAll((x) => {
            Console.WriteLine("Value of x is: {0}.", x);
            return x % 2 == 0;
        });
    }
}