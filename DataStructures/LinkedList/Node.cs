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
        if (obj == null || Element == null) return false;
        if (this.GetType() != obj.GetType()) return false;

        Node<T> other = (Node<T>)obj;

        return Element.Equals(other.Element);
    }

    public override string ToString() {
        return $"{Element} => {Next}";
    }
}