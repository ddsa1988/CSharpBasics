namespace Basics.Delegates;
public class DelegatesPlugInMethods {
    public static void UserMain() {
        int[] numbers = new int[] { 1, 2, 3 };

        PrintCollection.Print(numbers);
        Console.WriteLine();

        Transform(numbers, Power);
        PrintCollection.Print(numbers);

    }

    private static void Transform(int[] values, Transformer t) {
        for (int i = 0; i < values.Length; i++) {
            values[i] = t(values[i]);
        }
    }

    private delegate int Transformer(int x);

    private static int Power(int a) {
        return a * a;
    }
}

