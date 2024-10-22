namespace Basics.Classes.Models;

public class StudentTest {
    private const int DefaultSize = 5;
    private static Student[] students;

    static StudentTest() {
        students = new Student[DefaultSize];

        for (int i = 0; i < DefaultSize; i++) {
            string name = "Name " + i;
            string email = "Email " + i;
            string phone = "Phone " + 1;

            students[i] = new Student(name, email, phone);
        }
    }

    public static void PrintStudents() {
        foreach (Student student in students) {
            Console.WriteLine(student);
        }
    }
}