using System.Text;

namespace Basics.TextFiles.Exercises;

public class Exercise005 {
    // Write a program that reads a square matrix of integers from a file and finds the sub-matrix
    // with size 2 × 2 that has the maximal sum and writes this sum to a separate text file.
    // The first line of input file contains the size of the recorded matrix (N). The next N lines
    // contain N integers separated by spaces.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise005.txt";

        string text = ReadFile(filePath);

        string[] strArray = GetStringArray(text);
        GetMatrix(strArray);
    }

    private static int[,] GetMatrix(string[] strArray) {
        if (strArray.Length == 0) {
            throw new ArgumentException("Parameter is empty.", nameof(strArray));
        }

        bool isMatrixSizeValid = int.TryParse(strArray[0], out int matrixSize) && matrixSize > 0;

        if (!isMatrixSizeValid) {
            throw new ArgumentOutOfRangeException(nameof(strArray),
                "First index of the array must be the matrix size and it's value greater than zero.");
        }

        int[,] matrix = new int[matrixSize, matrixSize];
        int size = strArray.Length - 1;

        try {
            for (int i = 0; i < size; i++) {
                string[] row = strArray[i + 1].Split(" ");

                for (int j = 0; j < matrixSize; j++) {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }

        return matrix;
    }

    private static string[] GetStringArray(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Parameter is empty or null.", nameof(text));
        }

        string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

        return lines;
    }

    private static string ReadFile(string filePath) {
        if (!File.Exists(filePath)) return "";

        var sb = new StringBuilder();

        try {
            using var reader = new StreamReader(filePath);

            while (!reader.EndOfStream) {
                sb.AppendLine(reader.ReadLine());
            }
        } catch (IOException) {
            Console.Error.WriteLine($"Can't read file '{filePath}'.");
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }

        return sb.ToString();
    }
}