namespace Basics.Arrays.Examples;

public class Example005 {
    // Find the sub-matrix of size of 2 by 2 with maximum sum of its elements and to print it to the console.
    public static void UserMain() {
        int[,] matrix = {
            // Two-dimensional array with 4 rows and 6 columns
            { 0, 2, 4, 0, 9, 5 },
            { 7, 1, 3, 3, 2, 1 },
            { 1, 3, 9, 8, 5, 6 },
            { 4, 6, 7, 9, 1, 0 }
        };

        long bestSum = 0;
        int bestRow = 0;
        int bestColumn = 0;

        int firstDimensionSize = matrix.GetLength(0);
        int secondDimensionSize = matrix.GetLength(1);

        for (int row = 0; row < firstDimensionSize - 1; row++) {
            for (int column = 0; column < secondDimensionSize - 1; column++) {
                long sum = matrix[row, column] + matrix[row, column + 1] + matrix[row + 1, column] +
                           matrix[row + 1, column + 1];

                if (sum <= bestSum) continue;

                bestSum = sum;
                bestRow = row;
                bestColumn = column;
            }
        }

        Console.WriteLine($"The best platform is: ");
        Console.WriteLine("{0} {1}", matrix[bestRow, bestColumn], matrix[bestRow, bestColumn + 1]);
        Console.WriteLine("{0} {1}", matrix[bestRow + 1, bestColumn], matrix[bestRow + 1, bestColumn + 1]);
        Console.WriteLine("The maximum sum is: {0}.", bestSum);
    }
}