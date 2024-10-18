namespace Basics.Classes.Examples;

public class Example008 {
    // Static classes => only allow static fields, properties and methods
    public static void UserMain() {
        Test.Print();
    }

    private static class Test {
        private static string text = "This is a static field.";

        public static void Print() {
            Console.WriteLine(text);
        }
    }
}