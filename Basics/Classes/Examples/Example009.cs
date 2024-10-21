using System.Diagnostics;

namespace Basics.Classes.Examples;

public class Example009 {
    // Static constructors
    public static void UserMain() {
        Console.WriteLine(Test.value);
        Console.WriteLine(Test.value);
        Console.WriteLine(Test.value);
    }

    private class Test {
        public static int value;

        static Test() {
            value = 100;
            Console.WriteLine("Constructor executed");
        }
    }
}