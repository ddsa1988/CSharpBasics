namespace Basics.Arrays.Exercises;

public class Exercise007 {
    // Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers.
    // Find those K consecutive elements in the array, which have maximal sum.
    // Example: {10, 12, 9, 8, 10, 15, 1, 3, 2}, K = 3 => {9, 8, 10} = 27 
    // Example: {7, 20, 2, 3, 4}, K = 2 => {3,4} = 7

    public static void UserMain() {
        int[] source = [10, 12, 9, 8, 10, 15, 1, 3, 2];
        int n = source.Length;
        int k = 3;
        int bestSum = 0;

        for (int i = 0; i <= n - k; i++) {
            int[] tempArray = new int[k];

            Array.Copy(source, i, tempArray, 0, k);
            Array.Sort(tempArray);

            bool flag = true;

            for (int j = 0; j < k - 1; j++) {
                int actual = tempArray[j];
                int next = tempArray[j + 1];

                if (next - actual == 1) continue;

                flag = false;
                break;
            }

            if (!flag) continue;

            int tempArrayLength = tempArray.Length;
            int tempSum = 0;

            for (int j = 0; j < tempArrayLength; j++) {
                tempSum += tempArray[j];
            }

            bestSum = Math.Max(bestSum, tempSum); ;
        }

        Console.WriteLine($"The maximal sum of {k} consecutive elements is the array [{string.Join(", ", source)}] is {bestSum}.");
    }
}