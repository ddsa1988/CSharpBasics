namespace Basics.Arrays.Exercises;

public class Exercise007 {
    // Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers.
    // Find those K consecutive elements in the array, which have maximal sum.

    public static void UserMain() {
        const int n = 10;
        const int k = 3;

        int auxSum = 0;
        int bestSum = 0;
        int counter = 0;

        int[] source = [7, 8, 1, 2, 6, 9, 5, 4, 3, 0];

        Array.Sort(source);

        for (int i = 0; i < n; i++) {
            auxSum += source[i];
            counter++;

            if (counter < k) continue;

            counter = 0;

            if (auxSum < bestSum) continue;

            bestSum = auxSum;
        }

        Console.WriteLine(bestSum);
    }
}