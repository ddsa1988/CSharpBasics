namespace Basics.Principles_OOP.Models;

public class Dog : Animal {
    public Dog(string name, int age, string gender) : base(name, age, gender) { }

    public override string MakeSound() {
        return "Dog sound";
    }
}