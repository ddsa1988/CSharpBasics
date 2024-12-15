using System.Text;

namespace DataStructures.LinkedList.Models;

public class SinglyLinkedList<T> {
    public SinglyNode<T>? Head { get; private set; }
    public int Count { get; private set; }

    public SinglyLinkedList() {
        Head = null;
    }

    public void Push(T element) {
        if (element == null) throw new ArgumentNullException(nameof(element));
        
        var node = new SinglyNode<T>(element);

        if (Head == null) {
            Head = node;
        } else {
            SinglyNode<T> current = Head;

            while (current.Next != null) {
                current = current.Next;
            }

            current.Next = node;
        }

        Count++;
    }

    public void InsertAt(T element, int index) {
        if (element == null) throw new ArgumentNullException(nameof(element));
        
        if (Head == null || index >= Count) {
            Push(element);
        } else {
            var node = new SinglyNode<T>(element);

            if (index == 0) {
                node.Next = Head;
                Head = node;
            } else {
                SinglyNode<T> previous = GetNodeAt(index - 1);
                SinglyNode<T>? current = previous.Next;

                node.Next = current;
                previous.Next = node;
            }

            Count++;
        }
    }

    public int IndexOf(T element) {
        if (Head == null) throw new InvalidOperationException("List is empty");
        if (element == null) throw new ArgumentNullException(nameof(element));

        SinglyNode<T>? current = Head;

        for (int i = 0; i < Count && current != null; i++) {
            if (element.Equals(current.Element)) {
                return i;
            }

            current = current.Next;
        }

        return -1;
    }

    private SinglyNode<T> GetNodeAt(int index) {
        if (Head == null) throw new InvalidOperationException("List is empty");

        ArgumentOutOfRangeException.ThrowIfLessThan(index, 0, nameof(index));
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, Count, nameof(index));

        SinglyNode<T> singlyNode = Head;

        for (int i = 0; i < index && singlyNode.Next != null; i++) {
            singlyNode = singlyNode.Next;
        }

        return singlyNode;
    }

    public T? GetElementAt(int index) {
        SinglyNode<T> current = GetNodeAt(index);

        return current.Element;
    }

    public int Remove(T element) {
        if (element == null) throw new ArgumentNullException(nameof(element));
        if (Head == null) throw new InvalidOperationException("List is empty");

        int index = IndexOf(element);

        if (index < 0) return -1;

        RemoveAt(index);
        return index;
    }

    public T RemoveAt(int index) {
        if (Head == null) throw new InvalidOperationException("List is empty");

        SinglyNode<T> current = Head;

        if (index == 0) {
            Head = current.Next;
        } else {
            SinglyNode<T> previous = GetNodeAt(index - 1);
            current = previous.Next ?? throw new IndexOutOfRangeException("Index is out of range");
            previous.Next = current.Next;
        }

        Count--;
        return current.Element;
    }

    public void Clear() {
        Head = null;
        Count = 0;
    }

    public bool IsEmpty() {
        return Count == 0;
    }

    public override string ToString() {
        if (Head == null) return string.Empty;

        var sb = new StringBuilder();

        SinglyNode<T> current = Head;

        while (current.Next != null) {
            sb.Append(current.Element + "\n");
            current = current.Next;
        }

        sb.Append(current.Element);

        return sb.ToString();
    }
}