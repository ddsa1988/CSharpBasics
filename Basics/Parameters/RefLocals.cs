namespace Basics.Parameters;

public class RefLocals {
    public static void UserMain() {
        int n1 = 10;
        ref int n2 = ref n1; //Ref local can be used with arrays, local variables and fields

        Console.WriteLine("Assign => n1 = 10\n");
        Console.WriteLine("ref int n2 = ref n1;\n");
        Console.WriteLine("n1 = {0}", n1);
        Console.WriteLine("n2 = {0}", n2);
        Console.WriteLine();

        n2 = 20;

        Console.WriteLine("Assign => n2 = 20\n");
        Console.WriteLine("n1 = {0}", n1);
        Console.WriteLine("n2 = {0}", n2);
    }
}