namespace Basics.ObjectType;

public class Boxing {
    public static void UserMain() {
        //Boxing is the act of converting a value-type instance to a reference-type instance
        int number = 10;
        object obj = number;

        Console.WriteLine("int number => " + number);
        Console.WriteLine("object obj => " + obj);
        Console.WriteLine(number.GetType());
        Console.WriteLine(obj.Equals(number));
        Console.WriteLine();

        number = 50;

        Console.WriteLine("int number => " + number);
        Console.WriteLine("object obj => " + obj);
        Console.WriteLine(number.GetType());
        Console.WriteLine(obj.Equals(number));
    }
}