namespace Basics.UsingObjects.Exercises;

public class Exercise002 {
    // Write a program, which generates and prints on the console 10 random numbers in the range [100, 200].
    public static void UserMain() {
        int quantity = 10;
        int start = 100;
        int end = 200;

        Console.WriteLine($"The {quantity} random numbers are: ");

        PrintRandomNumber(quantity, start, end);
    }

    private static void PrintRandomNumber(int quantity, int start, int end) {
        if (quantity < 0) throw new ArgumentOutOfRangeException(nameof(quantity), "Parameter must be greater than zero.");

        for (int i = 0; i < quantity; i++) {
            int number = GetRandomNumber(start, end);

            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    private static int GetRandomNumber(int start, int end) {
        Random random = new Random();

        if (end < start) {
            (start, end) = (end, start);
        }

        return random.Next(start, end + 1);
    }
}