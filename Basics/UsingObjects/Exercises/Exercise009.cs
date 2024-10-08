namespace Basics.UsingObjects.Exercises;

public class Exercise009 {
    // Write a program, which calculates the count of workdays between the current date and another given date after 
    // the current (inclusive). Consider that workdays are all days from Monday to Friday, which are not public holidays, 
    // except when Saturday is a working day. The program should keep a list of predefined public holidays, as well as a list of
    // predefined working Saturdays.
    public static void UserMain() {
        DateTime now = DateTime.Now;
        DateTime date1 = new DateTime(1988, 1, 22);
        DateTime date2 = DateTime.Parse("1968-1-22");

        TimeSpan elapsed = now.Subtract(date1);

        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(date1.ToShortDateString());
        Console.WriteLine(date2.ToShortDateString());
        Console.WriteLine(elapsed);
    }
}