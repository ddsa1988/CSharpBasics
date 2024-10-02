namespace Basics.Methods.Exercises;

public class Exercise001 {
    // Write a code that by given name prints on the console "Hello, <name>!" (for example: "Hello, Peter!").
    public static void UserMain() {
        Greeting("Diego");
        Greeting("Amanda");
    }

    private static void Greeting(string name) {
        Console.WriteLine("Hello, {0}!", name);
    }
}