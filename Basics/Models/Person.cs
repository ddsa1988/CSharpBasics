using System.Globalization;

namespace Basics.Models;

public class Person {
    private readonly string name;

    public Person(string name) {
        Name = name;
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj is not Person) return false;

        Person? other = obj as Person;

        return Name.Equals(other?.Name);
    }

    public string Name {
        get => name;
        init {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentNullException(nameof(value));
            }

            name = value;
        }
    }

    public override string ToString() {
        return "Name: " + Name;
    }
}