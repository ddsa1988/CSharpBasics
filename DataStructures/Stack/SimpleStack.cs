using System.Text;

namespace DataStructures.Stack;

public class SimpleStack<T> {
    private T?[] stack;
    private int size;
    public int Count { get; private set; }

    public SimpleStack(int size) {
        Size = size;
        stack = new T[Size];
    }

    public int Size {
        get => size;
        private set => size = value > 0 ? value : 0;
    }

    public bool Push(T item) {
        if (IsFull()) return false;

        stack[Count++] = item;

        return true;
    }

    public T? Pop() {
        if (IsEmpty()) return default;

        int index = --Count;
        T? item = stack[index];
        stack[index] = default;

        return item;
    }

    public T? Peek() {
        if (IsEmpty()) return default;

        int index = Count - 1;
        T? item = stack[index];

        return item;
    }

    public bool IsEmpty() => Count == 0;

    public bool IsFull() => Count == Size;

    public void Clear() {
        stack = new T[Size];
        Count = 0;
    }

    public void Resize(int newSize) {
        T?[] aux = new T[Size];

        for (int i = 0; i < Count; i++) {
            aux[i] = stack[i];
        }

        Size = newSize;
        stack = new T[Size];
        Count = Count > Size ? Size : Count;

        for (int i = 0; i < Count; i++) {
            stack[i] = aux[i];
        }
    }

    public override string ToString() {
        if (IsEmpty()) return string.Empty;

        StringBuilder sb = new StringBuilder("[");

        for (int i = 0; i < Count - 1; i++) {
            sb.Append(stack[i] + ", ");
        }

        sb.Append(stack[Count - 1] + "]");

        return sb.ToString();
    }
}