using DataStructures.LinkedList.Models;

namespace DataStructures.LinkedList.Examples;

public class Example001 {
    public static void UserMain() {
        var list = new UserLinkedList<string>();

        list.Push("Diego");
        list.Push("Amanda");
        list.Push("Amora");
        list.Push("Ameixa");

        Console.WriteLine(list.Count + "\n");
        Console.WriteLine(list + "\n");

        Console.WriteLine(list.GetElementAt(1)?.Element);
        Console.WriteLine(list.IndexOf("Amanda") + "\n");
        
        list.RemoveAt(3);
        Console.WriteLine(list.Count);
        Console.WriteLine(list);
        Console.WriteLine();
        
        list.InsertAt("Rodrigo", 3);
        Console.WriteLine(list);
        Console.WriteLine(list.Count);
    }
}