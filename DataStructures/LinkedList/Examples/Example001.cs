using DataStructures.LinkedList.Models;

namespace DataStructures.LinkedList.Examples;

public class Example001 {
    public static void UserMain() {
        var list = new UserLinkedList<string>();

        list.Push("Diego");
        list.Push("Amanda");
        list.InsertAt("Amora", 0);
        list.InsertAt("Ameixa", 2);

        Console.WriteLine(list + "\n");
        
        Console.WriteLine(list.Remove("Diego"));
        Console.WriteLine(list.RemoveAt(0));
        Console.WriteLine();
        
        Console.WriteLine(list);
        Console.WriteLine(list.Count);
    }
}