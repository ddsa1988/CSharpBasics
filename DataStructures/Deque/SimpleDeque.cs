using System.Text;

namespace DataStructures.Deque;

public class SimpleDeque<T> {
    private T?[] deque;
    private int size;
    public int Count { get; private set; } = 0;

    public SimpleDeque(int size) {
        Size = size;
        deque = new T[Size];
    }

    public int Size {
        get => size;
        private set => size = value > 0 ? value : 0;
    }

    public bool AddFront(T item) {
        if (IsFull()) return false;

        if (IsEmpty()) return AddBack(item);

        for (int i = Count; i > 0; i--) {
            deque[i] = deque[i - 1];
        }

        deque[0] = item;
        Count++;

        return true;
    }

    public bool AddBack(T item) {
        if (IsFull()) return false;

        deque[Count++] = item;

        return true;
    }

    public T? RemoveFront() {
        if (IsEmpty()) return default;

        T? item = deque[0];

        for (int i = 0; i < Count - 1; i++) {
            deque[i] = deque[i + 1];
        }

        deque[--Count] = default;

        return item;
    }

    public T? RemoveBack() {
        if (IsEmpty()) return default;

        int index = --Count;
        T? item = deque[index];
        deque[index] = default;

        return item;
    }

    public T? PeekFront() {
        if (IsEmpty()) return default;

        T? item = deque[0];

        return item;
    }

    public T? PeekBack() {
        if (IsEmpty()) return default;

        T? item = deque[Count - 1];

        return item;
    }

    public bool IsEmpty() => Count == 0;

    public bool IsFull() => Count == Size;

    public void Resize(int newSize) {
        T?[] aux = new T[Size];

        for (int i = 0; i < Count; i++) {
            aux[i] = deque[i];
        }

        Size = newSize;
        deque = new T[Size];
        Count = Count > Size ? Size : Count;

        for (int i = 0; i < Count; i++) {
            deque[i] = aux[i];
        }
    }

    public override string ToString() {
        if (IsEmpty()) return string.Empty;

        StringBuilder sb = new StringBuilder("[");

        for (int i = 0; i < Count - 1; i++) {
            sb.Append(deque[i] + ", ");
        }

        sb.Append(deque[Count - 1] + "]");

        return sb.ToString();
    }
}