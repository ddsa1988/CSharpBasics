namespace Basics.Methods.Examples;

public class Example001 {
    public static void UserMain() {
        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        int a = 10;
        Increment(a);
        Console.WriteLine();

        Console.WriteLine(string.Join(", ", numbers));
        ChangeArray(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    }

    //Pass arguments by value
    private static void Increment(int x) {
        Console.WriteLine(++x);
    }

    //Pass arguments by reference
    private static void ChangeArray(int[] arr) {
        if (arr.Length == 0) return;

        arr[0] = 100;
    }
}