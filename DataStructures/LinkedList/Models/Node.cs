namespace DataStructures.LinkedList.Models;

public class Node<T> {
    public T Element { get; private set; }
    public Node<T>? Next { get; set; }
    public Node(T element) {
        Element = element;
        Next = null;
    }
}