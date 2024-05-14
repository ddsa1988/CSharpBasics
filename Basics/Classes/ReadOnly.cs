namespace Basics.Classes;

public class ReadOnly {
    public readonly int IntValue = 10;

    public ReadOnly() { }

    public ReadOnly(int value) {
        IntValue = value;
    }

    public static void UserMain() {
        // ReadOnly x = new ReadOnly() { IntValue = 200 }; //Error - Read-only cannot be assigned after constructor
    }

    /*
     *
     The readonly modifier prevents a field from being modified after construction. A
     read-only field can be assigned only in its declaration or within the enclosing type’s
     constructor.

     public void Update(int value) { //Error - Read-only cannot be assigned after constructor
        IntValue = value;
    }
    */
}