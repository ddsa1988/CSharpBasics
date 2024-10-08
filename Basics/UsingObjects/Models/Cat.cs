namespace Basics.UsingObjects.Models;

public class Cat {
    private string name = "Unnamed";
    private string color = "Gray";

    public Cat() { }

    public Cat(string name, string color) {
        Name = name;
        Color = color;
    }

    public string Name {
        get => name;
        set => name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public string Color {
        get => color;
        set => color = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public void MakeSound() {
        Console.WriteLine($"Cat {Name} made sound!");
    }

    public override int GetHashCode() {
        return Name.GetHashCode() + Color.GetHashCode();
    }

    public override bool Equals(object? obj) {
        // if (obj == null) return false;
        // if (obj is not Cat) return false;

        // Cat? other = obj as Cat;

        // return Name.Equals(other?.Name) && Color.Equals(other?.Color);

        if (obj == null) return false;
        if (!typeof(Cat).IsInstanceOfType(obj)) return false;

        Cat? other = null;

        try {
            other = (Cat)obj;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        return other != null && Name.Equals(other.Name) && Color.Equals(other.Color);
    }

    public override string ToString() {
        return $"Name: {Name}, Color: {Color}";
    }
}