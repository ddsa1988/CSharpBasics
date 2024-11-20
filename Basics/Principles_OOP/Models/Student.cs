namespace Basics.Principles_OOP.Models;

public class Student : Human, IComparable<Student> {
    private float mark;

    public Student(string firstName, string lastName, float mark) : base(firstName, lastName) {
        Mark = mark;
    }

    public float Mark {
        get => mark;
        set {
            if (value < 0 || value > 100) {
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 100.");
            }

            mark = value;
        }
    }

    public int CompareTo(Student? other) {
        return other == null ? 1 : Mark.CompareTo(other.Mark);
    }

    public override string ToString() {
        return base.ToString() +
               "\nMark: " + Mark.ToString("F2");
    }
}