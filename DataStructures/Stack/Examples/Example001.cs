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

        PrintStack(stack);
        Console.WriteLine();

        stack.Resize(3);
        PrintStack(stack);
    }

    private static void PrintStack<T>(UserStack<T> stack) {
        for (int i = 0; i < stack.Count; i++) {
            Console.Write(stack[i] + " ");
        }
    }
}