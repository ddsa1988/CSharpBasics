namespace Basics.Loops.Examples;

public class Example002 {
    public static void UserMain() {
        const int exitLoop = 5;
        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        foreach (int number in numbers) {
            Console.Write(number + " ");
        }

        Console.WriteLine('\n');

        foreach (int number in numbers) {
            if (number == exitLoop) break;

            Console.Write(number + " ");
        }
    }
}