using System.Text;

namespace Basics.Generics.Models;

public class GenericList<T> {
    private const int DefaultCapacity = 10;
    private T?[] arr;
    public int Capacity { get; private set; }
    public int Count { get; private set; }

    public GenericList() : this(DefaultCapacity) { }

    public GenericList(int capacity) {
        Capacity = capacity;
        Count = 0;
        arr = new T[capacity];
    }

    private void ResizeArr() {
        T?[] tempArr = arr;
        Capacity += Capacity;
        arr = new T[Capacity];

        int length = tempArr.Length;

        for (int i = 0; i < length; i++) {
            arr[i] = tempArr[i];
        }
    }

    public void Add(T item) {
        if (IsFull()) {
            // throw new InvalidOperationException("List is full.");
            ResizeArr();
        }

        arr[Count++] = item;
    }

    public void AddByIndex(T item, int index) {
        if (IsFull()) {
            // throw new InvalidOperationException("List is full.");
            ResizeArr();
        }

        if (index < 0 || index >= Count) {
            throw new ArgumentOutOfRangeException(nameof(index), $"Parameter must be between 0 and {Count}.");
        }

        int indexLastItem = Count - 1;

        if (index == indexLastItem) {
            Add(item);
            return;
        }

        for (int i = indexLastItem; i >= index; i--) {
            arr[i + 1] = arr[i];
        }

        arr[index] = item;
        Count++;
    }

    public T? RemoveByIndex(int index) {
        if (IsEmpty()) {
            throw new InvalidOperationException("List is empty.");
        }

        if (index < 0 || index >= Count) {
            throw new ArgumentOutOfRangeException(nameof(index), $"Parameter must be between 0 and {Count}.");
        }

        T? item = arr[index];
        int indexLastItem = Count - 1;

        for (int i = index; i < indexLastItem; i++) {
            arr[i] = arr[i + 1];
        }

        arr[indexLastItem] = default(T);
        Count--;

        return item;
    }

    public int IndexOf(T item) {
        for (int i = 0; i < Count; i++) {
            if (item == null || !item.Equals(arr[i])) continue;

            return i;
        }

        return -1;
    }

    public void Clear() {
        arr = new T[Capacity];
        Count = 0;
    }

    public bool IsEmpty() {
        return Count <= 0;
    }

    public bool IsFull() {
        return Count >= Capacity;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < Count; i++) {
            sb.Append(arr[i] + "\n");
        }

        return sb.ToString();
    }
}