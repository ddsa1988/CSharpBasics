namespace Basics.LinearDataStructures.Examples;

public class Example003 {
    public static void UserMain() {
        var list = new List<string>();

        list.Add("Diego");
        list.Add("Amanda");

        foreach(string value in list) {
            Console.WriteLine(value);
        }
    }
}