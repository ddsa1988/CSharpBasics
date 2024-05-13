namespace Basics.Classes;

public class ThisReference {

    private readonly string str = "Test";
    private readonly int number = 10;

    public int GetNumber() {
        return this.number;
    }

    public override string ToString() {
        return this.str + " " + this.GetNumber();

    } 

    public static void UserMain() {
        ThisReference p1 = new ThisReference();
        Console.WriteLine(p1);
    }

}