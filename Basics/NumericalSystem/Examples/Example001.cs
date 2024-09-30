namespace Basics.NumericalSystem.Examples;

public class Example001 {
    public static void UserMain() {
        const int intValue = 10;
        const int intHexValue = 0x002A;

        string intValueBinary = Convert.ToString(intValue, 2);

        Console.WriteLine($"Number => {intValue}");
        Console.WriteLine($"{intValue} => {intValueBinary}");
        Console.WriteLine($"0x002A => {intHexValue}");
    }
}