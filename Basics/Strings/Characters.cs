namespace Basics.Strings;

public class Characters {
    public static void Char() {
        char a = 'D';
        char b = 'a';

        byte c = (byte)a;
        byte d = (byte)b;

        Console.WriteLine($"char = {a} => ASCII value = {c}");
        Console.WriteLine($"char = {b} => ASCII value = {d}");
    }

    public static void Unicode() {
        char copyrightSymbol = '\u00A9';
        char omegaSymbol = '\u03A9';
        char newLine = '\u000A';

        Console.WriteLine(copyrightSymbol);
        Console.WriteLine(omegaSymbol);
        Console.WriteLine("Some text." + newLine + "Another text.");
    }
}