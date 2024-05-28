namespace Basics.Generics;

public class GenericsBasics {
    public static void UserMain() {
        Stack<int> intStack = new Stack<int>(5);
        Stack<string> strStack = new Stack<string>(10);

        intStack.Push(10);
        intStack.Push(5);
        intStack.Push(8);
        Console.WriteLine(intStack);
        Console.WriteLine(intStack.Pop());
        Console.WriteLine(intStack);
        Console.WriteLine();

        strStack.Push("Diego");
        strStack.Push("Amanda");
        strStack.Push("Rodrigo");
        Console.WriteLine(strStack);
        Console.WriteLine(strStack.Pop());
        Console.WriteLine(strStack);
    }

    private class Stack<T> {
        private readonly int stackSize;
        private int position = 0;
        private T?[] stack;

        public Stack(int size) {
            stackSize = size;
            stack = new T[stackSize];
        }

        public void Push(T item) {
            stack[position++] = item;
        }

        public T? Pop() {
            if (IsEmpty()) return default;

            T? item = stack[--position];
            stack[position] = default;

            return item;
        }

        public void Clear() {
            stack = new T[stackSize];
            position = 0;
        }

        public int Size() {
            return position;
        }

        public bool IsEmpty() {
            return Size() == 0;
        }

        public override string ToString() {
            if (IsEmpty()) return string.Empty;

            StringBuilder sb = new StringBuilder("[");
            int loopSize = Size() - 1;

            for (int i = 0; i < loopSize; i++) {
                sb.Append(stack[i] + ", ");
            }

            sb.Append(stack[loopSize] + "]");

            return sb.ToString();
        }
    }
}