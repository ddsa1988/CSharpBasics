namespace Basics.Inheritance;

public class Student : Person {
    private long register;

    public Student() { }

    public Student(string fullName, DateTime dateOfBirth, long id, long register) : base(fullName, dateOfBirth, id) {
        Register = register;
    }

    public long Register {
        get => register;
        set => register = value > 0 ? value : 0;
    }

    public override string ToString() {
        return base.ToString() + "\nRegister: " + Register;
    }

    public static void UserMain() {
        Student student = new Student("Diego", new DateTime(1988, 1, 22), 10, 500);
        Console.WriteLine(student);
    }
}