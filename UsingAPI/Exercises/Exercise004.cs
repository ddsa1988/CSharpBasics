namespace UsingAPI.Exercises;

public class Exercise004 {
    public static void UserMain() {
        const int size = 20;

        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < size; i++) {
            numbers.Add(random.Next(0, size));
        }

        IEnumerable<int> evenNumbers = numbers.Where((number => number % 2 == 0));

        Console.Write("Random numbers: ");
        foreach (int number in numbers) {
            Console.Write(number + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Random even numbers: ");
        foreach (int number in evenNumbers) {
            Console.Write(number + " ");
        }
    }
}