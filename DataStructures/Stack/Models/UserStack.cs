namespace DataStructures.Stack.Models;

public class UserStack<T> {
    private T?[] arr;
    private const int DefaultCapacity = 5;
    public int Capacity { get; private set; }
    public int Count { get; private set; } = 0;

    public UserStack() : this(DefaultCapacity) { }

    public UserStack(int capacity) {
        Capacity = capacity;
        arr = new T[Capacity];
    }

    public void Push(T item) {
        if (IsFull()) throw new InvalidOperationException("Stack is full.");

        arr[Count] = item;
        Count++;
    }

    public T? Pop() {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty.");

        Count--;
        T? item = arr[Count];
        arr[Count] = default;

        return item;
    }

    public T? Peek() {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");

        T? item = arr[Count - 1];

        return item;
    }

    public bool IsEmpty() {
        return Count == 0;
    }

    public bool IsFull() {
        return Count == Capacity;
    }

    public void Clear() {
        arr = new T[Capacity];
        Count = 0;
    }

    public void Resize(int newCapacity) {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(newCapacity, 0, nameof(newCapacity));

        Capacity = newCapacity;
        T?[] tempArr = arr;
        arr = new T[Capacity];

        if (arr.Length < tempArr.Length) Count = arr.Length;

        for (int i = 0; i < Count; i++) {
            arr[i] = tempArr[i];
        }
    }

    public T? this[int index] {
        get {
            ArgumentOutOfRangeException.ThrowIfLessThan(index, 0, nameof(index));
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, Count, nameof(index));

            return arr[index];
        }
    }

    public override string ToString() {
        return '[' + string.Join(", ", arr) + ']';
    }
}