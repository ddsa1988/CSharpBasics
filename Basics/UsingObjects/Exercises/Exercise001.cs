namespace Basics.UsingObjects.Exercises;

public class Exercise001 {
    // Write a program, which reads from the console a year and checks if it is a leap year.
    public static void UserMain() {
        const int MinYear = 0;
        int year;

        while (true) {
            Console.Write("Type a year: ");
            string? userInput = Console.ReadLine();

            bool isYearValid = int.TryParse(userInput, out year) && year > MinYear;

            if (!isYearValid) continue;

            break;
        }

        bool isLeapYear = IsLeapYear(year);
        string answer = isLeapYear ? "is" : "is not";

        Console.WriteLine($"The year {year} {answer} leap year.");
    }

    private static bool IsLeapYear(int year) {
        return DateTime.IsLeapYear(year);
    }
}