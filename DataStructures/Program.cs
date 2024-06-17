using DataStructures.Deque;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        SimpleDeque<int> deque = new SimpleDeque<int>(10);

        deque.AddFront(10);
        deque.AddBack(20);
        deque.AddBack(30);
        deque.AddFront(50);
        deque.AddBack(60);
        deque.AddFront(800);
        Console.WriteLine(deque);
        Console.WriteLine(deque.Count);
        deque.RemoveFront();
        Console.WriteLine(deque);
        Console.WriteLine(deque.Count);
    }
}