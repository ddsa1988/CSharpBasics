namespace Basics.LinearDataStructures.Exercises;

public class Exercise002 {
    // Write a program, which reads from the console N integers and prints them in reversed order. Use the Stack<int> class.
    public static void UserMain() {
        var numbers = new Stack<int>();
        var numbersReversed = new Stack<int>();

        while (true) {
            Console.Write("Type a integer number: ");
            string? userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput)) break;

            bool isNumberValid = int.TryParse(userInput, out int number);

            if (!isNumberValid) continue;

            numbers.Push(number);
        }

        if (numbers.Count == 0) return;

        Console.WriteLine("Numbers typed: {0}.", string.Join(", ", numbers));
        
        while (numbers.Count > 0) {
            numbersReversed.Push(numbers.Pop());
        }
        
        Console.WriteLine("Numbers reversed: {0}.", string.Join(", ", numbersReversed));
    }
}