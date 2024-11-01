namespace Basics.Strings.Examples;

public class Example007 {
    public static void UserMain() {
        const string sample = "amanda letícia nunes perna";
        string replaced = sample.Replace("a", "@");

        Console.WriteLine(sample);
        Console.WriteLine(replaced);
    }
}