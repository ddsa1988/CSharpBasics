namespace UsingAPI.Models;

public class Person {
    private DateTime _birthdate;
    private string _email;
    public string Name { get; init; }

    public Person() { }

    public Person(string name) {
        Name = name;
    }

    public Person(string name, DateTime birthdate) : this(name) {
        Birthdate = birthdate;
    }

    public Person(string name, DateTime birthdate, string email) : this(name, birthdate) {
        Email = email;
    }

    public DateTime Birthdate {
        get => _birthdate;
        set {
            DateTime now = DateTime.Now;
            TimeSpan elapsedSpan = now.Subtract(value);
            _birthdate = elapsedSpan.TotalSeconds > 0 ? value : now;
        }
    }

    public int Age {
        get {
            DateTime now = DateTime.Now;
            TimeSpan elapsedSpan = now.Subtract(_birthdate);
            double age = elapsedSpan.TotalDays / 365;

            return (int)age;
        }
    }

    public string Email {
        get => _email;
        set => _email = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? _email : value;
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;

        try {
            Person other = (Person)obj;
            return Name == other.Name;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        return false;
    }

    public override string ToString() {
        return "Name: " + Name +
               "\nBirthdate: " + Birthdate.ToShortDateString() +
               "\nAge: " + Age +
               "\nEmail: " + Email;
    }
}