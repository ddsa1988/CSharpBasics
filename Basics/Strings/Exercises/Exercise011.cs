namespace Basics.Strings.Exercises;

public class Exercise011 {
    // Write a program that reads a number from console and prints it in 15-character field, 
    // aligned right in several ways: as a decimal number, hexadecimal number, percentage, 
    // currency and exponential (scientific) notation.
    public static void UserMain() {
        const int sample = 20;

        Console.WriteLine($"Decimal => {sample:D}");
        Console.WriteLine($"Hexadecimal => 0x{sample:X}");
        Console.WriteLine($"Binary => 0b{sample:B}");
        Console.WriteLine($"Percentage => {sample / 100f:P}");
        Console.WriteLine($"Currency => {sample:C}");
        Console.WriteLine($"Exponential => {sample:E}");
    }
}