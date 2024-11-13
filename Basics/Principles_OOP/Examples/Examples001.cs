namespace Basics.Principles_OOP.Examples;

public class Example001 {
    public static void UserMain() {
        var p1 = new Person();
        var p2 = new Person("Amanda");
        var student = new Student("Diego", new DateTime(1988, 1, 22), 1);

        Console.WriteLine(p1 + "\n");
        Console.WriteLine(p2 + "\n");
        Console.WriteLine(student);
    }

    private class Person {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Person() : this("Unkown") { }

        public Person(string name) {
            Name = name;
        }

        public Person(string name, DateTime birthday) : this(name) {
            Birthday = birthday;
        }

        public override string ToString() {
            return "Name: " + Name +
                   "\nBirthday: " + Birthday.ToShortDateString();
        }
    }

    private class Student : Person {
        public int Id { get; set; }

        public Student(string name, DateTime birthday, int id) : base(name, birthday) {
            Id = id;
        }

        public override string ToString() {
            return base.ToString() +
                   "\nID: " + Id;
        }
    }
}