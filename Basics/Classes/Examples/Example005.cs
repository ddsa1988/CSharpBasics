namespace Basics.Classes.Examples;

public class Example005 {
    // Constant and readonly fields
    public static void UserMain() {
        Test test = new Test();
        // test.ReadOnlyField = "Test"; Compile error (readonly can't be assigned)
    }

    private class Test {
        public const string ConstField = "This is a const field";
        public readonly string ReadOnlyField;

        public Test() {
            ReadOnlyField = "This is a readonly field";
        }
    }
}