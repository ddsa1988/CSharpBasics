namespace Basics.LinearDataStructures.Models;

public class SimpleArrayList<T> {
    private const int DefaultCapacity = 4;
    private T[] arr;
    public int Count { get; private set; }

    public SimpleArrayList(int capacity = DefaultCapacity) {
        arr = new T[capacity];
        Count = 0;
    }

    private void GrowIfListIsFull() {
        if (Count < arr.Length) return;

        var tempArr = new T[arr.Length * 2];

        for (int i = 0; i < Count; i++) {
            tempArr[i] = arr[i];
        }

        arr = tempArr;
    }

    public void Add(T item) {
        GrowIfListIsFull();
        arr[Count++] = item;
    }

    public void Insert(int index, T item) {
        if (index < 0 || index > Count) {
            throw new IndexOutOfRangeException($"Invalid index: {index}");
        }

        GrowIfListIsFull();

        for (int i = Count; i > index; i--) {
            arr[i] = arr[i - 1];
        }

        arr[index] = item;
        Count++;
    }

    public int IndexOf(T item) {
        for (int i = 0; i < Count; i++) {
            if (Equals(item, arr[i])) return i;
        }

        return -1;
    }

    public T RemoveAt(int index) {
        if (index < 0 || index >= Count) {
            throw new IndexOutOfRangeException($"Invalid index: {index}");
        }

        T item = arr[index];

        int lastIndex = Count - 1;

        for (int i = index; i < lastIndex; i++) {
            arr[i] = arr[i + 1];
        }

        arr[lastIndex] = default(T);
        Count--;

        return item;
    }

    public int Remove(T item) {
        int index = IndexOf(item);

        if (index == -1) return index;

        RemoveAt(index);

        return index;
    }

    // Indexer: access to element at given index
    public T this[int index] {
        get {
            if (index < 0 || index > Count) {
                throw new IndexOutOfRangeException($"Invalid index: {index}");
            }

            return arr[index];
        }

        set {
            if (index < 0 || index >= Count) {
                throw new IndexOutOfRangeException($"Invalid index: {index}");
            }

            arr[index] = value;
        }
    }

    public bool Contains(T item) {
        int index = IndexOf(item);

        return index != -1;
    }

    public void Clear() {
        arr = new T[DefaultCapacity];
    }
}