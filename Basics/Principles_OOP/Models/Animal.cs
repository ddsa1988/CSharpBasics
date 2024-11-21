namespace Basics.Principles_OOP.Models;

public class Animal {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Animal(string name, int age, string gender) {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public virtual string MakeSound() {
        return "Animal sound";
    }

    public override string ToString() {
        return "Name: " + Name +
               "\nAge: " + Age +
               "\nGender: " + Gender;
    }
}