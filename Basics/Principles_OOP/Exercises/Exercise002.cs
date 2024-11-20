using Basics.Principles_OOP.Models;

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

        int length = students.Length;

        for (int i = 0; i < length; i++) {
            for (int j = i + 1; j < length; j++) {
                Student actual = students[i];
                Student next = students[j];

                int result = actual.CompareTo(next);

                if (result <= 0) continue;

                Swap(ref students[i], ref students[j]);
            }
        }

        foreach (Student student in students) {
            Console.WriteLine(student + "\n");
        }
    }

    private static void Swap<T>(ref T obj1, ref T obj2) {
        (obj1, obj2) = (obj2, obj1);
    }
}