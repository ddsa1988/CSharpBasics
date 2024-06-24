using DataStructures.LinkedList;
using DataStructures.Models;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        var list = new SimpleLinkedList<Person>();


        Person p1 = new Person("Diego", new DateTime(1988, 1, 22));
        Person p2 = new Person("Amanda", new DateTime(1993, 10, 16));
        Person p3 = new Person("Amora", new DateTime(2021, 12, 24));


        list.Push(p1);
        list.Push(p2);
        // list.Push(p3);
        Console.WriteLine(list);

        list.InsertAt(p3, 3);
        Console.WriteLine(list);
        Console.WriteLine(list.Count);
        Console.WriteLine(list.GetHead());
    }
}