namespace Basics.Principles_OOP.Models;

public class Teacher {
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Teacher(string name) {
        Name = name;
        Courses = new List<Course>();
    }
}