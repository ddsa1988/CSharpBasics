using static System.Net.Mime.MediaTypeNames;

namespace Basics.LinearDataStructures.Exercises;

public class Exercise004 {
    // Write a method that finds the longest subsequence of equal numbers in a given List<int> and
    // returns the result as new List<int>.Write a program to test whether the method works correctly.
    public static void UserMain() {
        var sourceList = new List<int>() { 0, 1, 1, 2, 3, 3, 3, 3, 3, 4, 5, 6, 6, 6, 6, 7, 7, 8, 9 };
        var targetList = new List<int>();

        Console.WriteLine("Source list: {0}.", string.Join(", ", sourceList));
    }
}