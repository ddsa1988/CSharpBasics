using System.Text.RegularExpressions;

namespace Basics.Strings.Exercises;
public partial class Exercise014 {
    // Write a program that reads two dates entered in the format "day.month.year" and calculates the number of days between them.
    // Enter the first date: 27.02.2006 Enter the second date: 3.03.2006. Distance: 4 days
    public static void UserMain() {
        string sample1 = "27.03.2006";
        string sample2 = "3.03.2006";

        Console.WriteLine(IsDateValid(sample1));
        Console.WriteLine(IsDateValid(sample2));
    }

    private static string[] GetDateArray(string text) {
        return new string[1];
    }

    private static bool IsDateValid(string text) {
        Regex regex = MyRegex();

        return regex.IsMatch(text);
    }

    [GeneratedRegex(@"^(0[1-9])|([1-2][0-9])|(3[0-1])\.(0[1-9])|(1[0-2])\.[0-9]{4}")]
    private static partial Regex MyRegex();
}