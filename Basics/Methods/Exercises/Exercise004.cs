namespace Basics.Methods.Exercises;

public class Exercise004 {
    // Write a method that finds how many times certain number can be found in a given array. 
    public static void UserMain() {
        int[] source = [1, 2, 3, 4, 1, 3, 3, 1, 1, 5, 3, 6, 3, 2];

        Console.WriteLine(CountOccurrences(source, 1));
        Console.WriteLine(CountOccurrences(source, 2));
        Console.WriteLine(CountOccurrences(source, 3));
        Console.WriteLine(CountOccurrences(source, 4));
        Console.WriteLine(CountOccurrences(source, 10));
    }

    private static int CountOccurrences(int[] arr, int number) {
        int counter = 0;

        foreach (int element in arr) {
            if (element == number) counter++;
        }

        return counter;
    }
}