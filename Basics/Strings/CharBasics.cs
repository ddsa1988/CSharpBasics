namespace Basics.Strings;

public class CharBasics {
    public static void UserMain() {
        Console.WriteLine(char.IsLetterOrDigit('a'));
        Console.WriteLine(char.IsLetterOrDigit('1'));
    }

    private static void Char() {
        const char a = 'D';
        const char b = 'a';

        const byte c = (byte)a;
        const byte d = (byte)b;

        Console.WriteLine($"char = {a} => ASCII value = {c}");
        Console.WriteLine($"char = {b} => ASCII value = {d}");
    }

    private static void Unicode() {
        const char copyrightSymbol = '\u00A9';
        const char omegaSymbol = '\u03A9';
        const char newLine = '\u000A';

        Console.WriteLine(copyrightSymbol);
        Console.WriteLine(omegaSymbol);
        Console.WriteLine("Some text." + newLine + "Another text.");
    }
}