using System.Text;

namespace DataStructures.Stack;

public class SimpleStack<T> {
    private T?[] _stack;
    private int _size;
    public int Count { get; private set; }

    public SimpleStack(int size) {
        Size = size;
        _stack = new T[Size];
    }

    public int Size {
        get => _size;
        private set => _size = value > 0 ? value : 0;
    }

    public bool Push(T item) {
        if (IsFull()) return false;

        _stack[Count++] = item;

        return true;
    }

    public T? Pop() {
        if (IsEmpty()) return default;

        int index = --Count;
        T? item = _stack[index];
        _stack[index] = default;

        return item;
    }

    public T? Peek() {
        if (IsEmpty()) return default;

        int index = Count - 1;
        T? item = _stack[index];

        return item;
    }

    public bool IsEmpty() => Count == 0;

    public bool IsFull() => Count == Size;

    public void Clear() {
        _stack = new T[Size];
        Count = 0;
    }

    public void Resize(int newSize) {
        T?[] aux = new T[Size];

        for (int i = 0; i < Count; i++) {
            aux[i] = _stack[i];
        }

        Size = newSize;
        _stack = new T[Size];
        Count = Count > Size ? Size : Count;

        for (int i = 0; i < Count; i++) {
            _stack[i] = aux[i];
        }
    }

    public override string ToString() {
        if (IsEmpty()) return string.Empty;

        StringBuilder sb = new StringBuilder("[");

        for (int i = 0; i < Count - 1; i++) {
            sb.Append(_stack[i] + ", ");
        }

        sb.Append(_stack[Count - 1] + "]");

        return sb.ToString();
    }
}