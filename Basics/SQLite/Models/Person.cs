namespace Basics.SQLite.Models;

public class Person {
    private string name = string.Empty;
    private DateTime birthday;

    public Person(string name, DateTime birthday) {
        Name = name;
        Birthday = birthday;
    }

    public string Name {
        get => name;
        set {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Name cannot be empty", nameof(value));
            }

            name = value;
        }
    }

    public DateTime Birthday {
        get => birthday;
        set {
            DateTime now = DateTime.Now;
            TimeSpan elapsed = now - value;

            if (elapsed < TimeSpan.Zero) {
                throw new ArgumentException("Birthday cannot be greater tha today", nameof(value));
            }

            birthday = value;
        }
    }

    public int GetAge() {
        const int daysInYear = 365;
        DateTime now = DateTime.Now;
        TimeSpan elapsed = now - Birthday;

        int age = elapsed.Days / daysInYear;

        return age;
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        var other = obj as Person;

        return other?.Name != null && other.Name.Equals(Name);
    }

    public override string ToString() {
        return "Name: " + Name +
               "\nBirthday: " + Birthday.ToShortDateString() +
               "\nAge: " + GetAge();
    }
}