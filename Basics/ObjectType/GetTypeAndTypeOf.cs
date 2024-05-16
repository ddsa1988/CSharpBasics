namespace Basics.ObjectType;

public class GetTypeAndTypeOf {
    private class Person {
        public string Name { get; set; }

        public Person(string name) {
            Name = name;
        }
    }

    private class Student : Person {
        private long id;

        public Student(string name, long id) : base(name) {
            Id = id;
        }

        public long Id {
            get => id;
            set => id = value > 0 ? value : 0;
        }
    }

    public static void UserMain() {
        Person p1 = new Person("Diego");
        Student s1 = new Student("Amanda", 1);

        Console.WriteLine("p1 GetType: " + p1.GetType().Name);
        Console.WriteLine("s1 GetType: " + s1.GetType().Name);
        Console.WriteLine();

        Console.WriteLine("typeof Class Person: " + typeof(Person).Name);
        Console.WriteLine("typeof Class Student: " + typeof(Student).Name);
        Console.WriteLine();

        Console.WriteLine("Class Person is instance of s1: " + typeof(Person).IsInstanceOfType(s1));
        Console.WriteLine("Class Student is instance of s1: " + typeof(Student).IsInstanceOfType(s1));
        Console.WriteLine("Class Student is instance of p1: " + typeof(Student).IsInstanceOfType(p1));
        Console.WriteLine("Class Student is subclass of Person: " + typeof(Student).IsSubclassOf(typeof(Person)));
    }
}