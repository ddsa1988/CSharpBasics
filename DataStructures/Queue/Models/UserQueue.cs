using System.Text;

namespace DataStructures.Queue.Models;

public class UserQueue<T> {
    private T?[] arr;
    private int capacity;
    private const int DefaultCapacity = 5;
    public int Count { get; private set; }

    public UserQueue() : this(DefaultCapacity) { }

    public UserQueue(int capacity) {
        Capacity = capacity;
        arr = new T?[capacity];
    }

    public int Capacity {
        get => capacity;
        private set {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(value, 0, nameof(value));
            capacity = value;
        }
    }

    public void Enqueue(T item) {
        if (IsFull()) throw new InvalidOperationException("Queue is full.");

        arr[Count++] = item;
    }

    public T? Dequeue() {
        if (IsEmpty()) throw new InvalidOperationException("Queue is empty.");

        T? item = arr[0];

        int lastIndex = --Count;

        for (int i = 0; i < lastIndex; i++) {
            arr[i] = arr[i + 1];
        }

        arr[lastIndex] = default;

        return item;
    }

    public T? Peek() {
        if (IsEmpty()) throw new InvalidOperationException("Queue is empty.");

        T? item = arr[0];

        return item;
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

    public void Resize(int newCapacity) {
        Capacity = newCapacity;
        T?[] tempArr = arr;
        arr = new T?[Capacity];

        if (arr.Length < tempArr.Length) Count = arr.Length;

        for (int i = 0; i < Count; i++) {
            arr[i] = tempArr[i];
        }
    }

    public T? this[int index] {
        get {
            ArgumentOutOfRangeException.ThrowIfLessThan(index, 0, nameof(index));
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, Count, nameof(index));

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