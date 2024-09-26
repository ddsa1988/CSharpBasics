namespace Basics.Arrays.Examples;

public class Example006 {
    // Jagged array - Arrays of arrays
    public static void UserMain() {
        int[][] jaggedArray = new int[2][];
        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[3];

        int[][] arrays = [
            [1, 2, 3, 4, 5],
            [6, 7, 8, 9],
            [10, 11, 12]
        ];

        Console.WriteLine(arrays.Length);
        Console.WriteLine(arrays[0].Length);
        Console.WriteLine(arrays[1].Length);
        Console.WriteLine(arrays[2].Length);
        Console.WriteLine();

        for (int i = 0; i < arrays.Length; i++) {
            for (int j = 0; j < arrays[i].Length; j++) {
                Console.Write(arrays[i][j] + " ");
            }
        }

        Console.WriteLine("\n");

        foreach (int[] array in arrays) {
            foreach (int value in array) {
                Console.Write(value + " ");
            }
        }
    }
}