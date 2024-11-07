namespace Basics.LinearDataStructures.Examples;

public class Example003 {
    public static void UserMain() {
        var list1 = new List<string>();
        var list2 = new List<string>();
        var list3 = new List<string>();

        list1.Add("Diego");
        list1.Add("Amanda");

        list2.Add("Amora");
        list2.Add("Ameixa");

        list3.AddRange(list2);
        list3.AddRange(list1);

        foreach (string value in list1) {
            Console.WriteLine(value);
        }

        Console.WriteLine();

        foreach (string value in list2) {
            Console.WriteLine(value);
        }

        Console.WriteLine();

        foreach (string value in list3) {
            Console.WriteLine(value);
        }
    }
}