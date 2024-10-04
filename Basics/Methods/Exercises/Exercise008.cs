using System.Runtime.InteropServices;

namespace Basics.Methods.Exercises;

public class Exercise008 {
    // Write a method that finds the biggest element of an array. Use that method to implement sorting in descending order.
    public static void UserMain() {
        int[] numbers = [-10, 5, 2, 10, 2, 100, 36, 58];

        SortDescendingOrder(numbers);

        Console.WriteLine(string.Join(", ", numbers));
    }

    private static void SortDescendingOrder(int[] arr) {
        int length = arr.Length;

        for (int i = 0; i < length; i++) {
            int element = arr[i];

            (int bestValue, int bestIndex) = GetBiggestElement(arr, i);

            if (bestValue <= element) continue;

            (arr[i], arr[bestIndex]) = (arr[bestIndex], arr[i]);
        }
    }

    private static (int, int) GetBiggestElement(int[] arr, int startIndex) {
        if (arr.Length == 0) throw new ArgumentException("Array is empty.");
        if (startIndex < 0 || startIndex >= arr.Length) throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index out of range.");

        int length = arr.Length;
        int bestValue = arr[startIndex];
        int bestIndex = startIndex;

        for (int i = startIndex + 1; i < length; i++) {
            int element = arr[i];

            if (element <= bestValue) continue;

            bestValue = element;
            bestIndex = i;
        }

        return (bestValue, bestIndex);
    }
}