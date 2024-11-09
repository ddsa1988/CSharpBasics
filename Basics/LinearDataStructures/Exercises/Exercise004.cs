namespace Basics.LinearDataStructures.Exercises;

public class Exercise004 {
    // Write a method that finds the longest subsequence of equal numbers in a given List<int> and
    // returns the result as new List<int>.Write a program to test whether the method works correctly.
    public static void UserMain() {
        var sourceList = new List<int>() { 0, 1, 1, 2, 3, 3, 3, 3, 3, 4, 5, 6, 6, 6, 6, 7, 7, 8, 8, 8, 8, 9 };

        var targetList = LongestSequence(sourceList);

        Console.WriteLine("Source: [{0}].", string.Join(", ", sourceList));
        Console.WriteLine("Longest equal number sequence: [{0}].", string.Join(", ", targetList));
    }

    private static List<int> LongestSequence(List<int> source) {
        var sequence = new List<int>();

        if (source.Count == 0) return sequence;

        int listLength = source.Count;
        int bestValue = source[0];
        int bestIndex = 0;
        int bestLength = 1;

        int value = bestValue;
        int length = bestLength;
        int index = bestIndex;

        for (int i = 1; i < listLength; i++) {
            int actualValue = source[i];

            if (actualValue == value) {
                length++;
                continue;
            }

            if (length > bestLength) {
                bestValue = value;
                bestLength = length;
                bestIndex = index;
            }

            value = actualValue;
            length = 1;
            index = i;
        }

        for (int i = bestIndex; i < bestIndex + bestLength; i++) {
            sequence.Add(source[i]);
        }

        return sequence;
    }
}