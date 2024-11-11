namespace Basics.LinearDataStructures.Exercises;

public class Exercise007 {
    // Write a program that finds in a given array of integers (in the range [0…1000]) how many times each of them occurs.
    // Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    // Result: 2 -> 2 times, 3 -> 4 times, 4 -> 3 times
    public static void UserMain() {
        List<int> sourceList = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        sourceList.Sort();

        Dictionary<int, int> countOccurrences = CountOccurrences(sourceList);

        PrintDictionary(countOccurrences);
    }

    private static Dictionary<int, int> CountOccurrences(List<int> sourceList) {
        var countOccurrences = new Dictionary<int, int>();

        if (sourceList.Count == 0) return countOccurrences;

        foreach (int value in sourceList) {
            if (countOccurrences.TryAdd(value, 1)) continue;

            countOccurrences[value]++;
        }

        return countOccurrences;
    }

    private static void PrintDictionary(Dictionary<int, int> dictionary) {
        foreach (int key in dictionary.Keys) {
            int value = dictionary[key];

            Console.WriteLine("{0} -> {1} times.", key, value);
        }
    }
}