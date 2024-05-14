namespace Basics.Classes;

public class ConstructorOverload {
    private readonly string name = string.Empty;
    private readonly int age;

    public ConstructorOverload() { }

    public ConstructorOverload(string name) {
        this.name = name;
    }

    public ConstructorOverload(string name, int age) : this(name) {
        this.age = age;
    }

    public override string ToString() {
        return $"Name: {this.name} \nAge: {age}";
    }
}