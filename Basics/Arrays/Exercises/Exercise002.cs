namespace Basics.Arrays.Exercises;

public class Exercise002 {
    // Write a program, which reads two arrays from the console and checks whether they are equal(two arrays are
    // equal when they are of equal length and all of their elements, which have the same index, are equal).

    public static void UserMain() {
        int[] n1 = [100, 200, 300];
        int[] n2 = [100];
        int[] n3 = [200, 100, 300];
        int[] n4 = [100, 200, 300];

        Console.WriteLine(AreEqual(n1, n2));
        Console.WriteLine(AreEqual(n1, n3));
        Console.WriteLine(AreEqual(n1, n4));
    }

    private static bool AreEqual(int[] arr1, int[] arr2) {
        if (arr1.Length != arr2.Length) return false;

        for (int i = 0; i < arr1.Length; i++) {
            if (arr1[i] != (arr2[i])) return false;
        }

        return true;
    }
}