namespace Basics.Generics.Models;

public class GenericList<T> {
    private const int DefaultCapacity = 10;
    private int counter;
    private readonly T?[] arr;
    public int Capacity { get; private set; }

    public GenericList() : this(DefaultCapacity) { }

    public GenericList(int capacity) {
        Capacity = capacity;
        counter = 0;
        arr = new T[capacity];
    }
}