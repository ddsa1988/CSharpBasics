namespace Basics.Principles_OOP.Models;

public class Cat : Animal {
    public Cat(string name, int age, string gender) : base(name, age, gender) { }

    public override string MakeSound() {
        return "Cat sound";
    }
}