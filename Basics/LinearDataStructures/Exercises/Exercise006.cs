namespace Basics.LinearDataStructures.Exercises;

public class Exercise006 {
    // Write a program that removes from a given sequence all numbers that appear an odd count of times.
    // Example: array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
    public static void UserMain() {
        var sourceList = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

        Dictionary<int, int> countOccurrences = CountOccurrences(sourceList);
        List<int> targetList = RemoveOddOccurrencesValues(sourceList, countOccurrences);

        Console.WriteLine("Source list: [{0}].", string.Join(", ", sourceList));
        Console.WriteLine("Target list: [{0}].", string.Join(", ", targetList));
    }

    private static Dictionary<int, int> CountOccurrences(List<int> sourceList) {
        var countValues = new Dictionary<int, int>();

        if (sourceList.Count == 0) return countValues;

        foreach (int value in sourceList) {
            if (countValues.TryAdd(value, 1)) continue;

            countValues[value]++;
        }

        return countValues;
    }

    private static List<int> RemoveOddOccurrencesValues(List<int> sourceList, Dictionary<int, int> countOccurrences) {
        var result = new List<int>();

        if (sourceList.Count == 0 || countOccurrences.Count == 0) return result;

        foreach (int value in sourceList) {
            if (!countOccurrences.TryGetValue(value, out int occurrence)) continue;
            
            if (occurrence % 2 != 0) continue;

            result.Add(value);
        }

        return result;
    }
}