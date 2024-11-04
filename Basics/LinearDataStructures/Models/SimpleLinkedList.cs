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

    public int Remove(T item) {
        int currentIndex = 0;
        ListNode<T>? currentNode = head;
        ListNode<T>? previousNode = null;

        while (currentNode != null) {
            if (Equals(item, currentNode.Element)) break;

            previousNode = currentNode;
            currentNode = currentNode?.Next;
            currentIndex++;
        }

        if (currentNode != null) {
            RemoveNode(currentNode, previousNode);
            return currentIndex;
        }

        return -1;
    }

    public int IndexOf(T item) {
        int currentIndex = 0;
        ListNode<T>? currentNode = head;

        while (currentNode != null) {

            if (Equals(item, currentNode.Element)) return currentIndex;

            currentNode = currentNode.Next;
            currentIndex++;
        }

        return -1;
    }

    public bool Contains(T item) {
        int index = IndexOf(item);
        return index != -1;
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