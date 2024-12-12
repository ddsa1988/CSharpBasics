using System.Text;

namespace DataStructures.LinkedList.Models;

public class UserLinkedList<T> {
    private Node<T>? head;
    public int Count { get; private set; }

    public UserLinkedList() {
        head = null;
    }

    public void Push(T element) {
        var newNode = new Node<T>(element);

        if (head == null) {
            head = newNode;
        } else {
            Node<T> current = head;

            while (current.Next != null) {
                current = current.Next;
            }

            current.Next = newNode;
        }

        Count++;
    }

    public void InsertAt(T element, int index) {
        IsIndexValid(index);
        
        if (head == null) {
            Push(element);
        } else {
            var newNode = new Node<T>(element);

            if (index == 0) {
                newNode.Next = head;
                head = newNode;
            } else {
                Node<T>? previous = GetElementAt(index - 1);

                if (previous == null) return;

                Node<T>? current = previous.Next;
                newNode.Next = current;
                previous.Next = newNode;
            }

            Count++;
        }
    }

    public int IndexOf(T element) {
        if (head == null || element == null) return -1;

        Node<T> current = head;
        int index = 0;

        while (current.Next != null) {
            if (element.Equals(current.Element)) {
                return index;
            }

            current = current.Next;
            index++;
        }

        return -1;
    }

    public Node<T>? GetElementAt(int index) {
        if (head == null) return default;

        IsIndexValid(index);

        Node<T> current = head;

        for (int i = 0; i < index && current.Next != null; i++) {
            current = current.Next;
        }

        return current;
    }

    public void RemoveAt(int index) {
        if (head == null) return;

        IsIndexValid(index);

        if (index == 0) {
            head = head.Next;
        } else {
            Node<T>? previous = GetElementAt(index - 1);

            if (previous == null) return;

            Node<T>? current = previous.Next;
            previous.Next = current?.Next;
        }

        Count--;
    }

    public void Clear() {
        head = null;
        Count = 0;
    }

    public bool IsEmpty() {
        return Count == 0;
    }

    private bool IsIndexValid(int index) {
        ArgumentOutOfRangeException.ThrowIfLessThan(index, 0, nameof(index));
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, Count, nameof(index));

        return true;
    }

    public override string ToString() {
        if (head == null) return string.Empty;

        var sb = new StringBuilder();

        Node<T> current = head;

        while (current.Next != null) {
            sb.Append(current.Element + "\n");
            current = current.Next;
        }

        sb.Append(current.Element);

        return sb.ToString();
    }
}