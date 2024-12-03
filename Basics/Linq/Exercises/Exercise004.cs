using Basics.Linq.Models;

namespace Basics.Linq.Exercises;

public class Exercise004 {
    // Write a class Student with the following properties: first name, last name and age.
    // Create a LINQ query that finds the first and the last name of all students, aged between 18 and 24 years including
    public static void UserMain() {
        var students = new Student[] {
            new() { FirstName = "Diego", LastName = "Alexandre", Age = 36 },
            new() { FirstName = "Amanda", LastName = "Perna", Age = 18 },
            new() { FirstName = "Rodrigo", LastName = "Santos", Age = 30 },
            new() { FirstName = "Mirelli", LastName = "Alexandre", Age = 20 },
            new() { FirstName = "Tainara", LastName = "Santos", Age = 24 },
        };

        IEnumerable<string> result =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student.FirstName + " " + student.LastName;

        Console.WriteLine(string.Join("\n", result));
    }
}