namespace DataStructures.LinkedList;

public class Node<T> {
    public T Element { get; init; }
    public Node<T>? Next { get; set; }

    public Node(T element) {
        Element = element;
        Next = null;
    }

    public override int GetHashCode() {
        return Element?.GetHashCode() ?? -1;
    }

    public override bool Equals(object? obj) {
        if (obj is not Node<T>) return false;

        Node<T>? other = obj as Node<T>;

        if (Element == null || other == null) return false;

        return Element.Equals(other.Element);
    }

    public override string ToString() {
        return $"{Element} => {Next}";
    }
}