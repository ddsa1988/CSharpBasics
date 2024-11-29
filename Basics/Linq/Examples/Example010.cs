namespace Basics.Linq.Examples;

public class Example010 {
    // Grouping results with Linq
    public static void UserMain() {
        int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13];
        const int divisor = 5;

        var numberGroups =
            from number in numbers
            group number by number % divisor
            into groups
            select new { Reminder = groups.Key, Numbers = groups };

        foreach (var group in numberGroups) {
            Console.WriteLine("Numbers with a remainder of {0} when divided by {1}: {2}",
                group.Reminder, divisor, string.Join(", ", group.Numbers));
        }
    }
}