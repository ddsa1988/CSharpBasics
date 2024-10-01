namespace Basics.Methods.Examples;

public class Example002 {
    public static void UserMain() {
        string text = "This is an array";

        PrintArray(text, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
    }

    private static void PrintArray(string text, params int[] arr) {
        if (arr == null || arr.Length == 0) return;

        Console.Write($"{text}: [{string.Join(", ", arr)}]");
    }
}