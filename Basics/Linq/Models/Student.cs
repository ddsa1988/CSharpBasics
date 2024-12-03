namespace Basics.Linq.Models;

public class Student {
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }

    public override string ToString() {
        return "First name: " + FirstName +
               ", Last name: " + LastName +
               ", Age: " + Age;
    }
}