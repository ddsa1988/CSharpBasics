namespace Basics.LinearDataStructures.Examples;

public class Example005 {
    public static void UserMain() {
        var stack = new Stack<string>();

        stack.Push("1. Diego");
        stack.Push("2. Amanda");
        stack.Push("3. Amora");
        stack.Push("4. Ameixa");

        Console.WriteLine("Top stack: " + stack.Peek() + "\n");

        while (stack.Count > 0) {
            Console.WriteLine(stack.Pop());
        }
    }
}