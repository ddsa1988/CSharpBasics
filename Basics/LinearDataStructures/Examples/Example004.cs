namespace Basics.LinearDataStructures.Examples;

public class Example004 {
    public static void UserMain() {
        var list = new LinkedList<string>();

        list.AddFirst("Diego");
        list.AddFirst("Amanda");
        list.AddLast("Amora");

        foreach (string item in list) {
            Console.WriteLine(item);
        }
    }
}