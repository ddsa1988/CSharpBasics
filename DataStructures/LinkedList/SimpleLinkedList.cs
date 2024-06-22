using System.Text;

namespace DataStructures.LinkedList;

public class SimpleLinkedList<T> {
    private Node<T>? head;
    private Node<T>? tail;
    public int Count { get; private set; }

    public bool IsEmpty() => Count == 0;

    public bool Push(T element) {
        Node<T> node = new Node<T>(element);

        if (IsEmpty()) {
            head = node;
            Count++;
            return true;
        }

        Node<T>? current = head;

        while (current?.Next != null) {
            current = current.Next;
        }

        if (current != null) {
            current.Next = node;
            Count++;
            return true;
        }

        return false;
    }

    public T? GetElementAt(int index) {
        if (IsEmpty()) return default;
        if (index < 0 || index >= Count) return default;

        return default;
    }

    public int IndexOf(T element) {
        return -1;
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