namespace Basics.Classes.Models;

public class Dog {
    // Field declaration
    private string? name;

    //Constructor declaration (parameterless empty constructor)
    public Dog() { }

    // Constructor declaration (with parameters)
    public Dog(string name) {
        Name = name;
    }

    // Property declaration
    public string? Name {
        get { return name; }
        set { name = value; }
    }

    // Method declaration (non-static)
    public void Bark() {
        Console.WriteLine("{0} said Wow-wow", Name ?? "[unnamed dog]");
    }
}