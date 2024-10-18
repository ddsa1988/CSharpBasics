namespace Basics.Classes.Models;

public class Constructor {
    private string text;
    private int number;
    private float grade;

    public Constructor(string text) {
        this.text = text;
        number = 0;
        grade = 0.0f;

        Console.WriteLine("First constructor.");
    }

    public Constructor(string text, int number) : this(text) {
        this.number = number;

        Console.WriteLine("Second constructor.");
    }

    public Constructor(string text, int number, float grade) : this(text, number) {
        this.grade = grade;

        Console.WriteLine("Third constructor.");
    }
}