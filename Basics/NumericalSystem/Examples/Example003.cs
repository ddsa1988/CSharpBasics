namespace Basics.NumericalSystem.Examples;

public class Example003 {
    public static void UserMain() {
        double number = 0;

        Console.WriteLine("Number => " + number);
        Console.WriteLine($"1/{number} => {1 / number}");
        Console.WriteLine($"-1/{number} => {-1 / number}");
        Console.WriteLine($"{number}/{number} => {number / number}");
    }
}