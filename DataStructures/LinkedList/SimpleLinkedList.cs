using System.Text;

namespace DataStructures.LinkedList;

public class SimpleLinkedList<T> {
    private Node<T>? head;
    private Node<T>? tail;
    public int Count { get; private set; }

    public bool IsEmpty() => Count == 0;

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        if (IsEmpty()) return sb.ToString();

        Node<T>? current = head;

        while (current != null) {
            sb.Append(current.Element);
            current = current.Next;
        }

        return sb.ToString();
    }
}