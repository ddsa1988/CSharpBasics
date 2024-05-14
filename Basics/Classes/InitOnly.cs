namespace Basics.Classes;

public class InitOnly {
    public int Number { get; init; } = 20;

    public InitOnly() { }

    public InitOnly(int value) {
        Number = value;
        
    }

    // public void SetNumber(int value) {
    //     Number = value; //Error - Init-only property
    // }

    public static void UserMain() {
        InitOnly x = new InitOnly() { Number = 50 };

        // x.Number = 200; //Error - Init-only property
    }
}