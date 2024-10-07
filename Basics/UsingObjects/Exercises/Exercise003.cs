namespace Basics.UsingObjects.Exercises;

public class Exercise003 {
    // Write a program, which prints, on the console which day of the week is today.
    public static void UserMain() {
        Console.WriteLine("Today is " + GetDayOfWeek() + ".");
    }

    private static string GetDayOfWeek() {
        return DateTime.Now.DayOfWeek.ToString();
    }
}