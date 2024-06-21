using DataStructures.LinkedList;
using DataStructures.Models;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        Person p1 = new Person("Diego");
        Person p2 = new Person("Amanda");
        Person p3 = new Person("Diego");

        Node<Person> n1 = new Node<Person>(p1);
        Node<Person> n2 = new Node<Person>(p2);
        Node<Person> n3 = new Node<Person>(p3);

        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p1.Equals(p3));
        Console.WriteLine();
        
        Console.WriteLine(n1.Equals(n2));
        Console.WriteLine(n1.Equals(n3));
    }
}