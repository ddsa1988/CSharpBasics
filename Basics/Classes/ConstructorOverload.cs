namespace Basics.Classes;

public class ConstructorOverload {
    public string Name = string.Empty;
    public int Age;

    public ConstructorOverload() { }

    public ConstructorOverload(string name) {
        Name = name;
    }

    public ConstructorOverload(string name, int age) : this(name) {
        Age = age;
    }

    public override string ToString() {
        return $"Name: {this.Name} \nAge: {Age}";
    }
}