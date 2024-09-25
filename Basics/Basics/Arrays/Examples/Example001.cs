namespace Basics.Arrays.Examples;

public class Example001 {
    public static void UserMain() {
        int[] array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int size = array.Length;
        int[] reversed = new int[size];

        for (int i = 0; i < size; i++) {
            int index = size - 1 - i;
            reversed[index] = array[i];
        }

        Console.WriteLine("Original array => " + string.Join(", ", array));
        Console.WriteLine("Reversed array => " + string.Join(", ", reversed));
    }
}