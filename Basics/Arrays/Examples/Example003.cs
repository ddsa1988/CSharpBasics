namespace Basics.Arrays.Examples;

public class Example003 {
    // Multidimensional Array
    public static void UserMain() {
        int[,] twoDimArr = new int[2, 3]; // Two-dimensional array with two rows and three columns

        int length = twoDimArr.Length; // Get the total length of the array
        int rows = twoDimArr.GetLength(0); // Get the length of the first dimension
        int columns = twoDimArr.GetLength(1); //Get the length of the second dimension

        Console.WriteLine($"Two dimensional array length is => {length}.");
        Console.WriteLine($"Two dimensional array rows is => {rows}.");
        Console.WriteLine($"Two dimensional array columns is => {columns}.");
        Console.WriteLine();
    }
}