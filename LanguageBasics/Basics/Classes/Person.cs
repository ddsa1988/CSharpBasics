namespace Basics.Classes;

public class Person {
    private string fullName = string.Empty;
    private DateTime dateOfBirth;
    private long id;

    public Person() { }

    public Person(string fullName, DateTime dateOfBirth, long id) {
        FullName = fullName;
        DateOfBirth = dateOfBirth;
        Id = id;
    }

    public string FullName {
        get => fullName;
        set => fullName = string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public DateTime DateOfBirth {
        get => dateOfBirth;
        set {
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now - value;

            dateOfBirth = timeSpan.Seconds > 0 ? value : now;
        }
    }

    public long Id {
        get => id;
        set => id = Math.Abs(value);
    }

    public string GetFirstName() {
        if (!FullName.Contains(' ')) {
            return FullName;
        }

        string[] names = FullName.Split(' ');

        return names[0];
    }

    public string GetLastName() {
        if (!FullName.Contains(' ')) {
            return FullName;
        }

        string[] names = FullName.Split(' ');

        return names[names.Length - 1];
    }

    public int GetAge() {
        const int daysInYear = 365;

        TimeSpan timeSpanAge = DateTime.Now - DateOfBirth;

        int age = timeSpanAge.Days / daysInYear;

        return age;
    }

    public override bool Equals(object? obj) {
        if (obj is not Person) return false;

        Person? other = obj as Person;

        return Id == other?.Id;
    }

    public override int GetHashCode() {
        return Id.GetHashCode();
    }

    public override string ToString() {
        return "Full Name: " + FullName +
               "\nBirthday: " + DateOfBirth.ToShortDateString() +
               "\nAge: " + GetAge();
    }
}