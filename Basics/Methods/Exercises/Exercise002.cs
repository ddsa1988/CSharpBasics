namespace Basics.Methods.Exercises;

public class Exercise002 {
    // Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. 
    // Write a program that reads three numbers from the console and prints the biggest of them.
    public static void UserMain() {
        Console.WriteLine(GetMax(8, 1, -10, 50, 25, 32, 110, 56, 89));
    }

    private static int GetMax(params int[] numbers) {
        if (numbers.Length == 0) {
            throw new ArgumentException("Parameter cannot be empty.");
        }

        int max = int.MinValue;

        foreach (int number in numbers) {
            if (number <= max) continue;

            max = number;
        }

        return max;
    }
}