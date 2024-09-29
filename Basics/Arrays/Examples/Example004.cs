namespace Basics.Arrays.Examples;

public class Example004 {
    // Multidimensional Array
    public static void UserMain() {
        int[,] twoDimArr = {
            // Two-dimensional array with two rows and four columns
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 }
        };

        int length = twoDimArr.Length;
        int rows = twoDimArr.GetLength(0);
        int columns = twoDimArr.GetLength(1);

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write(twoDimArr[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        foreach (int value in twoDimArr) {
            Console.Write(value + " ");
        }
    }
}