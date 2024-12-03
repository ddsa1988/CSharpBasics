using Basics.Linq.Models;

namespace Basics.Linq.Exercises;

public class Exercise005 {
    // Write a class Student with the following properties: first name, last name and age.
    // By using the extension methods OrderBy(...) and ThenBy(...) with lambda expression,
    // sort a list of students by their first and last name in descending order.
    // Rewrite the same functionality using a LINQ query.
    public static void UserMain() {
        var students = new List<Student> {
            new() { FirstName = "Diego", LastName = "Alexandre", Age = 36 },
            new() { FirstName = "Amanda", LastName = "Nunes", Age = 23 },
            new() { FirstName = "Mirelli", LastName = "Alexandre", Age = 20 },
            new() { FirstName = "Amanda", LastName = "Perna", Age = 18 },
            new() { FirstName = "Tainara", LastName = "Santos", Age = 24 },
            new() { FirstName = "Rodrigo", LastName = "Santos", Age = 30 },
        };

        IEnumerable<Student> result1 = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
        Console.WriteLine(string.Join("\n", result1));
        Console.WriteLine();

        IEnumerable<Student> result2 =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;

        Console.WriteLine(string.Join("\n", result2));
    }
}