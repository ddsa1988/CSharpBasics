namespace Basics.LinearDataStructures.Models;

public class ListNode<T> {
    public T Element { get; set; }
    public ListNode<T>? Next { get; set; }

    public ListNode(T element) {
        Element = element;
        Next = null;
    }

    public ListNode(T element, ListNode<T>? previous) {
        Element = element;
        if (previous == null) return;
        previous.Next = this;
    }
}