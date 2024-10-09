namespace Basics.ExceptionHandling.Exercises;

public class Exercise001 {
    // Write a program that takes a positive integer from the console and prints the square root of this integer. 
    // If the input is negative or invalid print "Invalid Number" in the console. In all cases print "Good Bye".
    public static void UserMain() {
        Console.Write("Type a positive integer number: ");
        string? userInput = Console.ReadLine();

        try {
            bool isNumberValid = int.TryParse(userInput, out int number);

            if (!isNumberValid || number < 0) {
                throw new Exception("Invalid Number");
            }

            double sqrt = Math.Sqrt(number);

            Console.WriteLine($"The square root of {number} is {sqrt:F2}.");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            Console.WriteLine("Good bye.");
        }
    }
}