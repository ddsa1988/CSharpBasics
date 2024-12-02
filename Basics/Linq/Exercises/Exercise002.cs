namespace Basics.Linq.Exercises;

public class Exercise002 {
    // Implement the following extension methods for the classes, implementing
    // the interface IEnumerable<T>: Sum(), Min(), Max(), Average().
    public static void UserMain() {
        IList<int> numbers = [1, 5, 7, -5];

        Console.WriteLine("Numbers => [{0}]", string.Join(", ", numbers));
        Console.WriteLine("Sum => " + numbers.Sum());
        Console.WriteLine("Min => " + numbers.Min());
        Console.WriteLine("Max => " + numbers.Max());
        Console.WriteLine("Average => " + numbers.Average());
    }
}

public static class EnumerableExtensions {
    public static int Sum(this IEnumerable<int> source) {
        IEnumerable<int> enumerable = source.ToList();

        if (!enumerable.Any()) throw new InvalidOperationException("Sequence contains no elements");

        int sum = 0;

        foreach (int value in enumerable) {
            sum += value;
        }

        return sum;
    }

    public static int Min(this IEnumerable<int> source) {
        IEnumerable<int> enumerable = source.ToList();

        if (!enumerable.Any()) throw new InvalidOperationException("Sequence contains no elements");

        int min = int.MaxValue;

        foreach (int value in enumerable) {
            min = Math.Min(min, value);
        }

        return min;
    }

    public static int Max(this IEnumerable<int> source) {
        IEnumerable<int> enumerable = source.ToList();

        if (!enumerable.Any()) throw new InvalidOperationException("Sequence contains no elements");

        int max = int.MinValue;

        foreach (int value in enumerable) {
            max = Math.Max(max, value);
        }

        return max;
    }

    public static int Average(this IEnumerable<int> source) {
        IEnumerable<int> enumerable = source.ToList();

        if (!enumerable.Any()) throw new InvalidOperationException("Sequence contains no elements");

        int sum = 0;

        foreach (int value in enumerable) {
            sum += value;
        }

        int avg = sum / enumerable.Count();

        return avg;
    }
}