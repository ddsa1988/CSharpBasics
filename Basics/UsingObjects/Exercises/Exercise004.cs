namespace Basics.UsingObjects.Exercises;

public class Exercise004 {
    // Write a program, which prints on the standard output the count of days, hours, and minutes, which have passes since
    // the computer is started until the moment of the program execution. For the implementation use the class Environment.
    public static void UserMain() {
        int ticks = Environment.TickCount;

        Console.WriteLine(ticks + " milliseconds.");
        Console.WriteLine(MillisecondsToSeconds(ticks) + " seconds.");
        Console.WriteLine(MillisecondsToMinutes(ticks) + " minutes.");
        Console.WriteLine(MillisecondsToHours(ticks) + " hours.");
        Console.WriteLine(MillisecondsToDays(ticks) + " days.");
    }

    private static int MillisecondsToSeconds(int milliseconds) {
        return milliseconds / 1000;
    }

    private static int MillisecondsToMinutes(int milliseconds) {
        return milliseconds / 1000 / 60;
    }

    private static int MillisecondsToHours(int milliseconds) {
        return milliseconds / 1000 / 60 / 60;
    }

    private static int MillisecondsToDays(int milliseconds) {
        return milliseconds / 1000 / 60 / 60 / 24;
    }
}