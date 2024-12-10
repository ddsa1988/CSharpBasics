using DataStructures.Deque.Models;

namespace DataStructures.Deque.Examples;

public class Example001 {
    // The deque data structure, also known as the double-ended queue, is a special queue that allows
    // us to insert and remove elements from the end or from the front of the queue.
    public static void UserMain() {
        var deque = new UserDeque<string>();
        
        deque.AddFront("Diego");
        deque.AddBack("Amanda");
        deque.AddFront("Ameixa");
        deque.AddBack("Amora");
        deque.AddFront("Rodrigo");
        
        Console.WriteLine(deque);
        Console.WriteLine(deque.Count);
    }
}