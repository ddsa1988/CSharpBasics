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

        }
    }

    public int IndexOf(T element) {
        return -1;
    }

    public T? GetElementAt(int index) {
        IsIndexValid(index);

        return default;
    }

    public void RemoveAt(int index) {
        IsIndexValid(index);
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
        if (IsEmpty()) return string.Empty;

        var sb = new StringBuilder();

        Node<T>? current = head;

        while (current != null) {
            sb.Append(current.Element + "\n");
            current = current.Next;
        }

        return sb.ToString();
    }
}