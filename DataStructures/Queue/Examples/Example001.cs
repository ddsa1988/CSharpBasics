using DataStructures.Queue.Models;

namespace DataStructures.Queue.Examples;

public class Example001 {
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