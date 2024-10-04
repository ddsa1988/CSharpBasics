namespace Basics.Methods.Exercises;

public class Exercise005 {
    // Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors.
    public static void UserMain() {
        Console.WriteLine(GreaterThanNeighbors([1, 3, 2], 1));
        Console.WriteLine(GreaterThanNeighbors([1], 0));
        Console.WriteLine(GreaterThanNeighbors([4, 3], 1));
    }

    private static bool GreaterThanNeighbors(int[] arr, int index) {
        if (!(index >= 0 && index < arr.Length)) throw new ArgumentOutOfRangeException(nameof(index), "Array index out of range.");

        if (arr.Length == 1) return true;

        if (index == 0 && arr.Length > 1) return arr[index] > arr[index + 1] && arr.Length == 2;

        if (index == arr.Length - 1) return arr[index] > arr[index - 1] && arr.Length == 2;

        return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
    }
}