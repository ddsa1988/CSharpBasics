namespace Basics.Principles_OOP.Models;

public class Class {
    public string Identifier { get; set; }
    public List<Teacher> Teachers { get; set; }

    public Class(string identifier) {
        Identifier = identifier;
        Teachers = new List<Teacher>();
    }
}