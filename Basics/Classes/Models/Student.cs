namespace Basics.Classes.Models;

public class Student {
    public static int CountStudents { get; private set; }
    public string Name { get; set; } = string.Empty;
    public string Course { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string University { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;

    public Student(string name, string email, string phone) {
        Name = name;
        Email = email;
        Phone = phone;

        CountStudents++;
    }

    public Student(string name, string course, string subject, string university, string email, string phone) : this(name, email, phone) {
        Course = course;
        Subject = subject;
        University = university;
    }

    public override string ToString() {
        return $"Name: {Name}, Course: {Course}, Subject: {Subject}, University: {University}, Email: {Email}, Phone: {Phone}";
    }
}