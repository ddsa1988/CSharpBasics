using System.Globalization;

namespace Basics.Strings.Exercises;
public partial class Exercise014 {
    // Write a program that reads two dates entered in the format "day.month.year" and calculates the number of days between them.
    // Enter the first date: 27.02.2006 Enter the second date: 3.03.2006. Distance: 4 days
    public static void UserMain() {
        const string dateFormat = "d.M.yyyy";
        const string sample1 = "27.02.2006";
        const string sample2 = "3.03.2006";

        DateTime start = GetDateFromString(sample1, dateFormat);
        DateTime end = GetDateFromString(sample2, dateFormat);

        int days = GetNumberOfDays(start, end);

        Console.WriteLine($"The difference between {start.ToShortDateString()} and {end.ToShortDateString()} is {days} days.");
    }

    private static int GetNumberOfDays(DateTime start, DateTime end) {
        int days = end.Subtract(start).Days;

        return days > 0 ? days : 0;
    }

    private static DateTime GetDateFromString(string text, string dateFormat) {
        if (!IsDateValid(text, dateFormat)) {
            throw new ArgumentException($"Parameter is not a valid date", nameof(text));
        }

        DateTime date = DateTime.ParseExact(text, dateFormat, CultureInfo.InvariantCulture);

        return date;
    }

    private static bool IsDateValid(string text, string dateFormat) {
        bool isDateValid = DateTime.TryParseExact(text, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);

        return isDateValid;
    }
}