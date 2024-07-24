namespace Basics.AnonymousTypes;

/*
    An anonymous type is a simple class created by the compiler on the fly to store a set
    of values. 
 */

public class AnonymousTypesBasics {
    public static void UserMain() {
        var p1 = new { Name = "Diego", Age = 36 };
        var p2 = new { Name = "Diego", Age = 40 };

        Console.WriteLine(p1);
        Console.WriteLine(p1.Equals(p2));

        //p1.Name = "Amanda"; //Compile error. Read only property

        object p3 = Person;
        Console.WriteLine(p3);
    }

    private static object Person => new { Name = "Amanda", Age = 28 };
}