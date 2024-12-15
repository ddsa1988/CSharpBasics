namespace DataStructures.LinkedList.Models;

public class SinglyNode<T> {
    public T Element { get; private set; }
    public SinglyNode<T>? Next { get; set; }
    public SinglyNode(T element) {
        Element = element;
        Next = null;
    }
}