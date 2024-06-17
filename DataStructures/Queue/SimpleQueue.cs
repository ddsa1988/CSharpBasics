using System.Text;

namespace DataStructures.Queue;

public class SimpleQueue<T> {
    private T?[] queue;
    private int size;
    public int Count { get; private set; } = 0;

    public SimpleQueue(int size) {
        Size = size;
        queue = new T[Size];
    }

    public int Size {
        get => size;
        private set => size = value > 0 ? value : 0;
    }

    public bool Enqueue(T item) {
        if (IsFull()) return false;

        queue[Count++] = item;

        return true;
    }

    public T? Dequeue() {
        if (IsEmpty()) return default;

        T? item = queue[0];

        for (int i = 0; i < Count - 1; i++) {
            queue[i] = queue[i + 1];
        }

        queue[--Count] = default;

        return item;
    }

    public T? Peek() {
        if (IsEmpty()) return default;

        T? item = queue[0];

        return item;
    }

    public bool IsEmpty() => Count == 0;

    public bool IsFull() => Count == Size;

    public void Resize(int newSize) {
        T?[] aux = new T[Size];

        for (int i = 0; i < Count; i++) {
            aux[i] = queue[i];
        }

        Size = newSize;
        queue = new T[Size];
        Count = Count > Size ? Size : Count;

        for (int i = 0; i < Count; i++) {
            queue[i] = aux[i];
        }
    }

    public override string ToString() {
        if (IsEmpty()) return string.Empty;

        StringBuilder sb = new StringBuilder("[");

        for (int i = 0; i < Count - 1; i++) {
            sb.Append(queue[i] + ", ");
        }

        sb.Append(queue[Count - 1] + "]");

        return sb.ToString();
    }
}