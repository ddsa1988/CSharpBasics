namespace Basics.Methods.Exercises;

public class Exercise006 {
    // Write a method that returns the position of the first occurrence of an element from an array, 
    // such that it is greater than its two neighbors simultaneously. Otherwise the result must be -1.
    public static void UserMain() {
        Console.WriteLine(FirstOccurrence([1, 2, 3, 1]));
    }

    private static int FirstOccurrence(int[] arr) {
        int length = arr.Length;

        for (int i = 0; i < length; i++) {
            if (!GreaterThanNeighbors(arr, i)) continue;

            return i;
        }

        return -1;
    }

    private static bool GreaterThanNeighbors(int[] arr, int index) {
        if (!(index >= 0 && index < arr.Length)) throw new ArgumentOutOfRangeException(nameof(index), "Array index out of range.");

        if (arr.Length == 1) return true;

        if (index == 0 && arr.Length > 1) return arr[index] > arr[index + 1] && arr.Length == 2;

        if (index == arr.Length - 1) return arr[index] > arr[index - 1] && arr.Length == 2;

        return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
    }
}