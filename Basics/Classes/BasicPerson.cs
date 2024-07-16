namespace Basics.Classes;

public class BasicPerson {
    private string _fullName = string.Empty;
    private DateTime _dateOfBirth;
    private long _id;

    public BasicPerson() { }

    public BasicPerson(string fullName, DateTime dateOfBirth, long id) {
        FullName = fullName;
        DateOfBirth = dateOfBirth;
        Id = id;
    }

    public string FullName {
        get => _fullName;
        set => _fullName = string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public DateTime DateOfBirth {
        get => _dateOfBirth;
        set {
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now - value;

            _dateOfBirth = timeSpan.Seconds > 0 ? value : now;
        }
    }

    public long Id {
        get => _id;
        set => _id = Math.Abs(value);
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
        if (obj is not BasicPerson) return false;

        BasicPerson? other = obj as BasicPerson;

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
