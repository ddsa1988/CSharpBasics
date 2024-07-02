namespace Basics.Delegates;

public class DelegatesGeneric {
    public static void UserMain() {
        int[] n1 = new int[] { 1, 2, 3 };
        float[] n2 = new float[] { 1.5f, 2.2f, 3.7f };

        Transform<int>(n1, Sum);
        Transform<float>(n2, Sum);

        Console.Write("Integers: ");

        foreach (int number in n1) {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        Console.Write("Floats: ");

        foreach (float number in n2) {
            Console.Write(number + " ");
        }
    }

    private static void Transform<T>(T[] values, Transformer<T> t) {
        for (int i = 0; i < values.Length; i++) {
            values[i] = t(values[i]);
        }
    }

    private delegate T Transformer<T>(T arg);

    private static int Sum(int a) {
        return a + a;
    }

    private static float Sum(float a) {
        return a + a;
    }
}