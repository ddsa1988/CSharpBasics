namespace Basics.LinearDataStructures.Exercises;

public class Exercise005 {
    // Write a program, which removes all negative numbers from a sequence.
    // Example: array = {19, -10, 12, -6, -3, 34, -2, 5} -> {19, 12, 34, 5}
    public static void UserMain() {
        var sourceList = new List<int>() { 19, -10, 12, -6, -3, 34, -2, 5 };
        var targetList = new List<int>();

        foreach (int value in sourceList) {
            if (value < 0) continue;

            targetList.Add(value);
        }

        Console.WriteLine("Source: [{0}].", string.Join(", ", sourceList));
        Console.WriteLine("Source without negative numbers: [{0}].", string.Join(", ", targetList));
    }
}