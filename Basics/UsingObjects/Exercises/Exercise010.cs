namespace Basics.UsingObjects.Exercises;

public class Exercise010 {
    // You are given a sequence of positive integer numbers given as string of numbers separated by a space. 
    // Write a program, which calculates their sum. Example: "43 68 9 23 318" => 461.
    public static void UserMain() {
        string sample = "43 68 9 23 318";

        string[] strings = GetArrayOfStrings(sample);
        int[] numbers = GetArrayOfNumbers(strings);
        int sum = GetSumArrayNumbers(numbers);

        Console.WriteLine($"The sum of '{sample}' is {sum}.");
    }


    private static int GetSumArrayNumbers(int[] numbers) {
        int sum = 0;

        foreach (int number in numbers) {
            sum += number;
        }

        return sum;
    }

    private static int[] GetArrayOfNumbers(string[] input) {
        if (input == null || input.Length == 0) {
            throw new ArgumentException("String is null or empty.", nameof(input));
        }

        int inputLength = input.Length;
        int counter = 0;
        int[] numbers = new int[inputLength];

        foreach (string value in input) {
            bool isNumberValid = int.TryParse(value, out int number);

            if (!isNumberValid) continue;

            numbers[counter++] = number;
        }

        return numbers;
    }

    private static string[] GetArrayOfStrings(string input) {
        if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input) || input.Length == 0) {
            throw new ArgumentException("String is null or empty.", nameof(input));
        }

        string tempInput = input.Trim();
        string[] strings = tempInput.Split(" ");

        return strings;
    }
}