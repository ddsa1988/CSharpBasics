namespace Basics.Arrays.Exercises;

public class Exercise008 {
    // Sorting an array means to arrange its elements in an increasing (or decreasing) order. 
    // Write a program, which sorts an array using the algorithm "selection sort".

    public static void UserMain() {
        int[] source = [10, 12, 9, 8, 10, 15, 1, 3, 2];
        int arrayLength = source.Length;

        Console.WriteLine($"Original array => [{string.Join(", ", source)}]\n");

        for (int i = 0; i < arrayLength - 1; i++) {
            int minIndex = i;

            for (int j = i + 1; j < arrayLength; j++) {
                int minValue = source[minIndex];
                int actual = source[j];

                if (actual > minValue) continue;

                minIndex = j;
            }

            if (minIndex == i) continue;

            Swap(ref source[i], ref source[minIndex]);

        }

        Console.WriteLine($"Sorted array => [{string.Join(", ", source)}]");
    }

    private static void Swap(ref int a, ref int b) {
        (a, b) = (b, a);
    }
}