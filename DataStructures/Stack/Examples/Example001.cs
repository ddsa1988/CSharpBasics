using DataStructures.Stack.Models;

namespace DataStructures.Stack.Examples;

public class Example001 {
    public static void UserMain() {
        var stack = new UserStack<int>();

        stack.Push(100);
        stack.Push(200);
        stack.Push(300);
        stack.Push(400);
        stack.Push(500);
        
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack);

        stack.Resize(3);
        Console.WriteLine(stack);
        
        Console.WriteLine(stack.Peek());
    }
}