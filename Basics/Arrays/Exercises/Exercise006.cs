namespace Basics.Arrays.Exercises;

public class Exercise006 {
    // Write a program, which finds the maximal sequence of increasing elements in an array arr[n].
    // It is not necessary the elements to be consecutively placed.
    // Example: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} => {2, 4, 5, 8}.

    public static void UserMain() {
        int[] source = [9, 6, 2, 7, 4, 7, 6, 5, 8, 4];
        int length = source.Length;
        int[] result = new int[length];
        int counter = 0;

        for (int i = 0; i < length; i++) {
            int[] tempResult = new int[length];
            int tempCounter = 1;
            int tempIndex = 1;

            tempResult[0] = source[i];

            for (int j = i + 1; j < length; j++) {
                if (source[j] > tempResult[tempIndex - 1]) {
                    tempResult[tempIndex] = source[j];
                    tempIndex++;
                    tempCounter++;
                } else if (tempIndex > 1 && source[j] > tempResult[tempIndex - 2] &&
                           source[j] < tempResult[tempIndex - 1])
                    tempResult[tempIndex - 1] = source[j];
            }

            if (counter >= tempCounter) continue;
            counter = tempCounter;
            result = tempResult;
        }

        for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);
    }
}