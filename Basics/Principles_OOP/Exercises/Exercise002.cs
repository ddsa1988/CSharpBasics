using Basics.Classes.Models;
using Student = Basics.Principles_OOP.Models.Student;

namespace Basics.Principles_OOP.Exercises;

public class Exercise002 {
    // Initialize an array of 10 students and sort them by mark in ascending order.Use the interface System.IComparable<T>
    public static void UserMain() {
        Student[] students = [
            new Student("Diego", "Alexandre", 88f),
            new Student("Amanda", "Perna", 75f),
            new Student("Rodrigo", "Santos", 70f),
            new Student("Ivanice", "Ramos", 60f),
            new Student("Tainara", "Alexandre", 82f),
            new Student("Mireli", "Santos", 92f),
            new Student("Amora", "Nunes", 85f),
            new Student("Ameixa", "Santos", 70f),
            new Student("Daniel", "Larusso", 100f),
            new Student("Jonas", "Pereira", 90f),
        ];
        
        foreach (Student student in students) {
            Console.WriteLine(student + "\n");
        }
    }
}