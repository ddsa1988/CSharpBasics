namespace Basics.Strings.Examples;

public class Example005 {
    public static void UserMain() {
        const string sample = "Diego dos Santos Alexandre";

        string middleName = sample.Substring(10, 6);
        string lastName = sample.Substring(17, 9);

        Console.WriteLine(middleName);
        Console.WriteLine(lastName);
    }
}