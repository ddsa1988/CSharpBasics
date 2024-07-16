namespace Basics.Classes;

public class ConstructorOverload {
    private readonly string _name = string.Empty;
    private readonly int _age;

    public ConstructorOverload() { }

    public ConstructorOverload(string name) {
        _name = name;
    }

    public ConstructorOverload(string name, int age) : this(name) {
        _age = age;
    }

    public override string ToString() {
        return $"Name: {_name} \nAge: {_age}";
    }
}