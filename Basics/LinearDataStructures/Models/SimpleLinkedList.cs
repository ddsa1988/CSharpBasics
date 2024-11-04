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

    public T? RemoveAt(int index) {
        if (index < 0 || index >= Count) {
            throw new IndexOutOfRangeException($"Invalid index: {index}");
        }

        int currentIndex = 0;
        ListNode<T>? currentNode = head;
        ListNode<T>? previousNode = null;

        while (currentIndex < index) {
            previousNode = currentNode;
            currentNode = currentNode?.Next;
            currentIndex++;
        }

        RemoveNode(currentNode, previousNode);

        return currentNode == null ? default(T) : currentNode.Element;
    }

    private void RemoveNode(ListNode<T>? node, ListNode<T>? previousNode) {
        Count--;
        
        if (Count == 0) {
            head = null;
            tail = head;
        } else if (previousNode == null) {
            head = node?.Next;
        } else {
            previousNode = node?.Next;
        }

        if (Equals(tail, node)) {
            tail = previousNode;
        }
    }
}