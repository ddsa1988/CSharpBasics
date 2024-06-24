using System.Text;

namespace DataStructures.LinkedList;

public class SimpleLinkedList<T> {
    private Node<T>? head;
    public int Count { get; private set; }

    public bool IsEmpty() => Count == 0;

    public bool Push(T element) {
        Node<T> node = new Node<T>(element);

        if (IsEmpty()) {
            head = node;
        }
        else {
            Node<T>? current = head;

            while (current?.Next != null) {
                current = current.Next;
            }

            if (current == null) return false;

            current.Next = node;
        }

        Count++;
        return true;
    }

    public bool InsertAt(T element, int index) {
        if (index < 0 || element == null) return false;

        if (index >= Count) return Push(element);

        Node<T> node = new Node<T>(element);

        if (index == 0) {
            node.Next = head;
            head = node;
        }
        else {
            Node<T>? previous = GetNodeAt(index - 1);

            if (previous == null) return false;

            node.Next = previous.Next;
            previous.Next = node;
        }

        Count++;
        return true;
    }

    public T? GetHead() {
        return head != null ? head.Element : default;
    }

    private Node<T>? GetNodeAt(int index) {
        if (index < 0 || index >= Count) return default;

        Node<T>? current = head;

        for (int i = 0; i < index; i++) {
            current = current?.Next;
        }

        return current;
    }

    public T? GetElementAt(int index) {
        Node<T>? node = GetNodeAt(index);

        return node != null ? node.Element : default;
    }

    public int IndexOf(T element) {
        Node<T>? current = head;

        for (int i = 0; i < Count; i++) {
            if (element != null && current != null && element.Equals(current.Element)) {
                return i;
            }

            current = current?.Next;
        }

        return -1;
    }

    public bool Remove(T element) {
        if (element == null) return false;

        int index = IndexOf(element);

        return element.Equals(RemoveAt(index));
    }

    public T? RemoveAt(int index) {
        if (index < 0 || index >= Count) return default;

        Node<T>? current = head;

        switch (index) {
            case 0:
                head = head?.Next;
                break;
            default: {
                Node<T>? previous = GetNodeAt(index - 1);
                current = previous?.Next;

                if (previous == null || current == null) return default;

                previous.Next = current.Next;
                break;
            }
        }

        Count--;
        return current != null ? current.Element : default;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        if (IsEmpty()) return sb.ToString();

        Node<T>? current = head;

        while (current != null) {
            sb.Append(current.Element + "\n");
            current = current.Next;
        }

        return sb.ToString();
    }
}