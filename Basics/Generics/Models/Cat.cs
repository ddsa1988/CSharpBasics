namespace Basics.Generics.Models;

public class Cat {
    public string Name { get; set; }

    public Cat() : this(string.Empty) { }

    public Cat(string name) {
        Name = name;
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;
        if (obj is not Dog) return false;
        if (ReferenceEquals(this, obj)) return true;

        Dog? other = obj as Dog;

        return Name.Equals(other?.Name);
    }

    public override string ToString() {
        return "Name: " + Name;
    }
}