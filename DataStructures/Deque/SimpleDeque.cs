using System.Text;

namespace DataStructures.Deque;

public class SimpleDeque<T> {
    private T?[] _deque;
    private int _size;
    public int Count { get; private set; } = 0;

    public SimpleDeque(int size) {
        Size = size;
        _deque = new T[Size];
    }

    public int Size {
        get => _size;
        private set => _size = value > 0 ? value : 0;
    }

    public bool AddFront(T item) {
        if (IsFull()) return false;

        if (IsEmpty()) return AddBack(item);

        for (int i = Count; i > 0; i--) {
            _deque[i] = _deque[i - 1];
        }

        _deque[0] = item;
        Count++;

        return true;
    }

    public bool AddBack(T item) {
        if (IsFull()) return false;

        _deque[Count++] = item;

        return true;
    }

    public T? RemoveFront() {
        if (IsEmpty()) return default;

        T? item = _deque[0];

        for (int i = 0; i < Count - 1; i++) {
            _deque[i] = _deque[i + 1];
        }

        _deque[--Count] = default;

        return item;
    }

    public T? RemoveBack() {
        if (IsEmpty()) return default;

        int index = --Count;
        T? item = _deque[index];
        _deque[index] = default;

        return item;
    }

    public T? PeekFront() {
        if (IsEmpty()) return default;

        T? item = _deque[0];

        return item;
    }

    public T? PeekBack() {
        if (IsEmpty()) return default;

        T? item = _deque[Count - 1];

        return item;
    }

    public bool IsEmpty() => Count == 0;

    public bool IsFull() => Count == Size;

    public void Resize(int newSize) {
        T?[] aux = new T[Size];

        for (int i = 0; i < Count; i++) {
            aux[i] = _deque[i];
        }

        Size = newSize;
        _deque = new T[Size];
        Count = Count > Size ? Size : Count;

        for (int i = 0; i < Count; i++) {
            _deque[i] = aux[i];
        }
    }

    public override string ToString() {
        if (IsEmpty()) return string.Empty;

        StringBuilder sb = new StringBuilder("[");

        for (int i = 0; i < Count - 1; i++) {
            sb.Append(_deque[i] + ", ");
        }

        sb.Append(_deque[Count - 1] + "]");

        return sb.ToString();
    }
}