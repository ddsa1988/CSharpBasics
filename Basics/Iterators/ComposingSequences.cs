namespace Basics.Iterators;

public class ComposingSequences {
    public static void UserMain() {
        int number = 20;

        foreach (int value in EvenNumbers(Fibonacci(number))) {
            Console.Write(value + " ");
        }
    }

    private static IEnumerable<int> Fibonacci(int count) {
        for (int i = 0, prev = 1, curr = 1; i < count; i++) {
            yield return prev;

            int aux = prev + curr;
            prev = curr;
            curr = aux;
        }
    }

    private static IEnumerable<int> EvenNumbers(IEnumerable<int> numbers) {
        foreach (int number in numbers) {
            if (number % 2 == 0) yield return number;
        }
    }
}