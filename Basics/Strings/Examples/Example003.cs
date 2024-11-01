namespace Basics.Strings.Examples;

public class Example003 {
    public static void UserMain() {
        const string sample = "amanda letícia nunes perna";

        Console.WriteLine(sample.IndexOf('n'));
        Console.WriteLine(sample.IndexOf('w'));

        Console.WriteLine(sample.LastIndexOf('n'));
    }
}