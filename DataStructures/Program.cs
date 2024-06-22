using DataStructures.LinkedList;
using DataStructures.Models;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        var list = new SimpleLinkedList<Person>();


        Person p1 = new Person("Diego", new DateTime(1988, 1, 22));
        Person p2 = new Person("Amanda", new DateTime(1993, 10, 16));
        Person p3 = new Person("Diego");


        Console.WriteLine(list.Push(p1));
        Console.WriteLine(list.Push(p2));
        Console.WriteLine(list.Push(p3));
        Console.WriteLine(list);
        Console.WriteLine(list.Count);

    }
}