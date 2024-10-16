using System.Globalization;

namespace Basics.Strings.Exercises;

public class Exercise015 {
    // Write a program that reads the date and time entered in the format "day.month.year hour:minutes:seconds" 
    // and prints the date and time after 6 hours and 30 minutes in the same format
    public static void UserMain() {
        string sample = "12.05.2024 10:12:58";
        string dateFormat = "d.M.yyyy H:m:s";

        DateTime date = GetDateFromString(sample, dateFormat);
        DateTime newDate = AddHours(date);

        Console.WriteLine($"The original date is {date} and the new date is {newDate}");
    }

    private static DateTime AddHours(DateTime date) {
        const double hours = 6;
        const double minutes = 30;

        DateTime newDate = date.AddHours(hours).AddMinutes(minutes);

        return newDate;
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