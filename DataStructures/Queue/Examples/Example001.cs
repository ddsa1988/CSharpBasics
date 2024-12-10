using DataStructures.Queue.Models;

namespace DataStructures.Queue.Examples;

public class Example001 {
    // A queue is an ordered collection of items that follows the first in, first out (FIFO),
    // also known as the first come, first served, principle. The addition of new elements
    // in a queue is at the tail, and the removal is from the front. The newest element
    // added to the queue must wait at the end of the queue.
    public static void UserMain() {
        var queue = new UserQueue<string>();
        
        queue.Enqueue("Diego");
        queue.Enqueue("Amanda");
        queue.Enqueue("Amora");
        queue.Enqueue("Ameixa");
        
        Console.WriteLine(queue);
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue);
    }
}