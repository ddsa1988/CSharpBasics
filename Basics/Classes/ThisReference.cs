namespace Basics.Classes;

public class ThisReference {
    private readonly string _str = "Test";
    private readonly int _number = 10;

    public static void UserMain() {
        ThisReference p1 = new ThisReference();
        Console.WriteLine(p1);
    }

    private int GetNumber() {
        return this._number;
    }

    public override string ToString() {
        return $"String: {this._str} \nNumber: {this.GetNumber()}";
    }
}