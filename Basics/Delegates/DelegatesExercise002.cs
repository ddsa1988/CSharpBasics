namespace Basics.Delegates;

public class DelegatesExercise002 {
    public static void UserMain() {
        Transformer<int> anyFunc1 = Func1;
        Transformer<string> anyFunc2 = Func2;

        anyFunc1(10);
        anyFunc2("Test");
    }

    private delegate void Transformer<T>(T arg);

    private static void Func1(int a) {
        Console.WriteLine(a + a);
    }

    private static void Func2(string a) {
        Console.WriteLine(a);
    }
}