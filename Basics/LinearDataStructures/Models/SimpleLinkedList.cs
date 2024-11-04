namespace Basics.LinearDataStructures.Models;

public class SimpleLinkedList<T> {
    private ListNode<T>? head;
    private ListNode<T>? tail;
    public int Count { get; private set; }

    public SimpleLinkedList() {
        head = null;
        tail = null;
        Count = 0;
    }

    public void Add(T item) {
        if (head == null) {
            head = new ListNode<T>(item);
            tail = head;
        } else {
            var newNode = new ListNode<T>(item, tail);
            tail = newNode;
        }

        Count++;
    }
}