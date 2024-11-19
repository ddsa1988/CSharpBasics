namespace Basics.Principles_OOP.Models;

public class Human {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Human(string firstName, string lastName) {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString() {
        return "First name: " + FirstName +
               "\nLast name: " + LastName;
    }
}