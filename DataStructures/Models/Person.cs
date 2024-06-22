namespace DataStructures.Models;

public class Person {
    private string name = string.Empty;
    private DateTime birthdate;

    public Person(string name) {
        Name = name;
        Birthdate = DateTime.Now;
    }

    public Person(string name, DateTime birthdate) : this(name) {
        Birthdate = birthdate;
    }

    public string Name {
        get => name;
        init => name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? name : value;
    }

    public DateTime Birthdate {
        get => birthdate;
        set {
            DateTime now = DateTime.Now;
            TimeSpan elapsedSpan = now.Subtract(birthdate);

            birthdate = elapsedSpan.Ticks > 0 ? value : now;
        }
    }

    public int Age {
        get {
            DateTime now = DateTime.Now;
            TimeSpan elapsedSpan = now.Subtract(Birthdate);

            int age = (int)elapsedSpan.TotalDays / 365;

            return age;
        }
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj is not Person) return false;

        Person? other = obj as Person;

        return Name.Equals(other?.Name);
    }

    public override string ToString() {
        return $"Name: {Name} Birthdate: {Birthdate.ToShortDateString()} Age: {Age}";
    }
}