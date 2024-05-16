namespace Basics.ObjectType;

public class Unboxing {
    public static void UserMain() {
        //Unboxing is the act of converting a reference-type instance to a value-type instance
        object obj = "10";
        string str = (string)obj;

        switch (obj) {
            case int x:
                Console.WriteLine(x + " is int");
                break;

            case double x:
                Console.WriteLine(x + " is double");
                break;

            case float x:
                Console.WriteLine(x + " is float");
                break;

            case string x:
                Console.WriteLine(x + " is string");
                break;

            case bool x:
                Console.WriteLine(x + " is bool");
                break;

            default:
                Console.WriteLine("Other type");
                break;
        }
    }
}