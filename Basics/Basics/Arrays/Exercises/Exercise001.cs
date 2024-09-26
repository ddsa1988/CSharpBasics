namespace Basics.Arrays.Exercises;

public class Exercise001 {
    // Write a program, which creates an array of 20 elements of type integer and initializes each of the elements
    // with a value equals to the index of the element multiplied by 5. Print the elements to the console.

    public static void UserMain() {
        const int size = 20;
        const int multiply = 5;
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++) {
            numbers[i] = i * multiply;
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}