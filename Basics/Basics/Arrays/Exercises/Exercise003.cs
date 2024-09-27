namespace Basics.Arrays.Exercises;

public class Exercise003 {
    // Write a program, which compares two arrays of type char lexicographically (character by character)
    // and checks, which one is first in the lexicographical order.

    public static void UserMain() {
        const string name1 = "Array 1";
        const string name2 = "Array 2";
        const string equal = "Equals";

        char[] arr1 = ['d', 'i', 'e', 'g', 'o'];
        char[] arr2 = ['d', 'i', 'e', 'g', 'o'];

        string first = arr1.Length < arr2.Length ? name1 : arr2.Length < arr1.Length ? name2 : equal;
        int size = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < size; i++) {
            int result = arr1[i].CompareTo(arr2[i]);

            if (result == 0) continue;

            first = result < 0 ? name1 : name2;
            break;
        }

        Console.WriteLine(first);
    }
}