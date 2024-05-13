namespace Basics.Classes;

public class ReadOnly {
    public readonly int IntValue = 10;

    public ReadOnly(int value) {
        IntValue = value;
    }

    /*
     * 
     The readonly modifier prevents a field from being modified after construction. A
     read-only field can be assigned only in its declaration or within the enclosing type’s
     constructor.
     
     public void Update(int value) { //Compile error
        IntValue = value;
    }
     
    */


}