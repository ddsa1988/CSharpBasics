namespace Basics.Linq.Exercises;

public class Exercise003 {
    // Write a class Student with the following properties: first name, last name and age.
    // Write a method that for a given array of students finds those, whose first name
    // is before their last one in alphabetical order. Use LINQ.
    public static void UserMain() {
        var students = new Student[] {
            new() { FirstName = "Diego", LastName = "Alexandre", Age = 36 },
            new() { FirstName = "Amanda", LastName = "Perna", Age = 31 },
            new() { FirstName = "Rodrigo", LastName = "Santos", Age = 30 },
        };

        IEnumerable<Student> result = from student in students
                                      where string.Compare(student.FirstName, student.LastName, StringComparison.OrdinalIgnoreCase) <= 0
                                      select student;

        Console.WriteLine(string.Join("\n", result));
    }

    private class Student {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        public override string ToString() {
            return "First name: " + FirstName +
                   ", Last name: " + LastName +
                   ", Age: " + Age;
        }

    }
}

