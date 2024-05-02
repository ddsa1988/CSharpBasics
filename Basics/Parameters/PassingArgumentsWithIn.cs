namespace Basics.Parameters;
public class PassingArgumentsWithIn {
    public static void UserMain() {
        Console.WriteLine("Passing arguments by reference (in modifier):\n");
        Console.WriteLine(@"The in modifier is most useful when passing a large value type to the method 
because it allows the compiler to avoid the overhead of copying the argument prior to passing it in while 
still protecting the original value from modification." + "\n");
    }
}
