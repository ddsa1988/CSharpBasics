namespace Basics.Classes;

public class ThisReference {
    private readonly string str = "Test";
    private readonly int number = 10;

    private int GetNumber() {
        return this.number;
    }

    public override string ToString() {
        return $"String: {this.str} \nNumber: {this.GetNumber()}";
    }

    public static void UserMain() {
        ThisReference p1 = new ThisReference();
        Console.WriteLine(p1);
    }
}