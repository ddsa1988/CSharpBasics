using System.Drawing;

namespace DataStructures.Stack;

public class SimpleStack<T> {
    private T?[] stack;
    private int size;
    public int Count { get; private set; }

    public SimpleStack(int size) {
        Size = size;
        stack = new T[Size];
    }

    public bool Push(T element) {
        if (IsFull()) return false;

        stack[Count++] = element;

        return true;
    }

    public T? Pop() {
        if (IsEmpty()) return default;

        int index = --Count;
        T? element = stack[index];
        stack[index] = default;

        return element;
    }

    public T? Peek() {
        if (IsEmpty()) return default;

        int index = Count - 1;
        T? element = stack[index];

        return element;
    }

    public int Size {
        get => size;
        private set => size = value > 0 ? value : 0;
    }

    public bool IsEmpty() => Size == 0;

    public bool IsFull() => Size == Count;

    public void Clear() {
        stack = new T[Size];
        Count = 0;
    }

    public override string ToString() {
        return "";
    }
}