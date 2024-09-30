namespace Basics.Arrays.Exercises;

public class Exercise005 {
    // Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4} => {2, 3, 4}.

    public static void UserMain() {
        int[] source = [3, 2, 3, 4, 2, 3, 4, 1, 2];

        int auxStart = 0;
        int auxLength = 1;
        int bestStart = 0;
        int bestLength = 1;
        int arrayLength = source.Length;

        for (int i = 0; i < arrayLength - 1; i++) {
            int actual = source[i];
            int next = source[i + 1];

            if (next > actual) {
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

        Console.Write(
            $"The maximal sequence of consecutively placed increasing elements: [{string.Join(", ", sequence)}]\n");
    }
}