using DataStructures.LinkedList.Models;

namespace DataStructures.LinkedList.Examples;

public class Example001 {
    public static void UserMain() {
        var list = new UserLinkedList<string>();

        list.Push("Diego");
        list.Push("Amanda");
        list.Push("Amora");
        list.Push("Ameixa");

        Console.WriteLine(list.RemoveAt(0) + "\n");
        Console.WriteLine(list);
        Console.WriteLine(list.Count);
    }
}