namespace DataStructures.Queue;

public class SimpleQueue<T> {
    private T[] stack;
    private int size;

    public SimpleQueue(int size) {
        Size = size;
        stack = new T[Size];
    }

    public int Size {
        get => size;
        private set => size = value > 0 ? value : 0;
    }

    public bool IsEmpty() => Size == 0;
}