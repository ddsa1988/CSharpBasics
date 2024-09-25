namespace Basics.Arrays.Examples;

public class Example003 {
    // Multidimensional Array
    public static void UserMain() {
        const int row = 3;
        const int column = 4;

        int[,] twoDimensionalArray = new int[row, column];

        Console.WriteLine(twoDimensionalArray.Length);

        int auxRow = twoDimensionalArray.GetLength(0);
        int auxCol = twoDimensionalArray.GetLength(1);

        for (int i = 0; i < auxRow; i++) {
            for (int j = 0; j < auxCol; j++) {
                twoDimensionalArray[i, j] = i + j;
            }
        }

        for (int i = 0; i < auxRow; i++) {
            for (int j = 0; j < auxCol; j++) {
                Console.Write(twoDimensionalArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}