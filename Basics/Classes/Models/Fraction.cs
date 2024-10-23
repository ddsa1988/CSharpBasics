namespace Basics.Classes.Models;

public class Fraction {
    private static int numerator;
    private static int denominator;

    public static void Parse(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text.Trim())) {
            throw new ArgumentException("Parameter is empty.", nameof(text));
        }
    }
}