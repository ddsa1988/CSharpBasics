namespace Basics.LinearDataStructures.Examples;

public class Example006 {
    public static void UserMain() {
        var queue = new Queue<string>();

        queue.Enqueue("1. Diego");
        queue.Enqueue("2. Amanda");
        queue.Enqueue("3. Amora");
        queue.Enqueue("4. Ameixa");

        Console.WriteLine("Top queue: " + queue.Peek() + '\n');

        while (queue.Count > 0) {
            Console.WriteLine(queue.Dequeue());
        }
    }
}