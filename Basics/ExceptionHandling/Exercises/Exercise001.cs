namespace Basics.ExceptionHandling.Exercises;

public class Exercise001 {
    // Write a program that takes a positive integer from the console and prints the square root of this integer. 
    // If the input is negative or invalid print "Invalid Number" in the console. In all cases print "Good Bye".
    public static void UserMain() {
        Console.Write("Type a positive integer number: ");
        string? userInput = Console.ReadLine();

        try {
            int number = int.Parse(userInput);

            if (number < 0) {
                throw new Exception("NegativeNumberException");
            }

            double sqrt = Math.Sqrt(number);

            Console.WriteLine($"The square root of {number} is {sqrt:F2}.");
        } catch (Exception) {
            Console.WriteLine("Invalid number.");
        } finally {
            Console.WriteLine("Good bye.");
        }
    }
}