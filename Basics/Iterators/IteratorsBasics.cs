namespace Basics.Iterators;

public class IteratorBasics {
    public static void UserMain() {
        foreach (int number in Test()) {
            Console.Write(number + " ");
        }
    }

    private static IEnumerable<int> Test() {
        int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int index = 0;

        while (index < numbers.Length) {
            yield return numbers[index++];
        }
    }
}