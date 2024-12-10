using System.Text;

namespace DataStructures.Deque.Models;

public class UserDeque<T> {
    private T?[] arr;
    private int capacity;
    private const int DefaultCapacity = 5;
    public int Count { get; private set; }

    public UserDeque() : this(DefaultCapacity) { }

    public UserDeque(int capacity) {
        Capacity = capacity;
        arr = new T?[Capacity];
    }

    public int Capacity {
        get => capacity;
        private set {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(value, 0, nameof(value));
            capacity = value;
        }
    }

    public void AddFront(T item) { }

    public void AddBack(T item) { }

    public T? RemoveFront() {
        return default;
    }

    public T? RemoveBack() {
        return default;
    }

    public T? PeekFront() {
        return default;
    }

    public T? PeekBack() {
        return default;
    }

    public bool IsEmpty() {
        return Count == 0;
    }

    public bool IsFull() {
        return Count == Capacity;
    }

    public void Clear() {
        arr = new T?[Capacity];
        Count = 0;
    }

    public void Resize(int newCapacity) { }

    public T? this[int index] {
        get {
            ArgumentOutOfRangeException.ThrowIfLessThan(index, 0, nameof(index));
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(index, Count, nameof(index));

            return arr[index];
        }
    }

    public override string ToString() {
        if (IsEmpty()) return "[]";

        var sb = new StringBuilder();
        sb.Append('[');
        int lastIndex = Count - 1;

        for (int i = 0; i < lastIndex; i++) {
            sb.Append(arr[i] + ", ");
        }

        sb.Append(arr[lastIndex] + "]");

        return sb.ToString();
    }
}