namespace Basics.NumericalSystem.Examples;

public class Example004 {
    public static void UserMain() {
        int controlLoop = 1000;

        {
            float sum = 0;
            float number = 0.1f;

            for (int i = 0; i < controlLoop; i++) {
                sum += number;
            }

            Console.WriteLine($"The sum of {number} float for {controlLoop} times is: {sum}.");
        }

        Console.WriteLine();

        {
            double sum = 0;
            double number = 0.1;

            for (int i = 0; i < controlLoop; i++) {
                sum += number;
            }

            Console.WriteLine($"The sum of {number} double for {controlLoop} times is: {sum}.");
        }

        Console.WriteLine();

        {
            decimal sum = 0;
            decimal number = 0.1m;

            for (int i = 0; i < controlLoop; i++) {
                sum += number;
            }

            Console.WriteLine($"The sum of {number} decimal for {controlLoop} times is: {sum}.");
        }

        Console.WriteLine();
    }
}