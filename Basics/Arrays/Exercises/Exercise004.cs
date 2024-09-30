namespace Basics.Arrays.Exercises;

public class Exercise004 {
    // Write a program, which finds the maximal sequence of consecutive equal elements in an array.
    // Example: {1, 1, 2, 3, 2, 2, 2, 1} => {2, 2, 2}.

    public static void UserMain() {
        int[] source = [1, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1];

        int auxStart = 0;
        int auxLength = 1;
        int bestStart = 0;
        int bestLength = 1;
        int arrayLength = source.Length;

        for (int i = 0; i < arrayLength - 1; i++) {
            int actual = source[i];
            int next = source[i + 1];

            if (actual == next) {
                if (auxLength == 1) auxStart = i;
                auxLength += 1;

                if (auxLength <= bestLength) continue;

                bestStart = auxStart;
                bestLength = auxLength;
            } else {
                auxStart = 0;
                auxLength = 1;
            }
        }

        int[] sequence = new int[bestLength];

        Array.Copy(source, bestStart, sequence, 0, bestLength);

        Console.WriteLine($"Source array: [{string.Join(", ", source)}]\n");

        Console.Write($"The maximal sequence of consecutive equal elements: [{string.Join(", ", sequence)}]\n");

    }
}