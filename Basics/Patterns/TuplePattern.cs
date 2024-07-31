using System.Xml.Serialization;

namespace Basics.Patterns;

public class TuplePattern {
    public static void UserMain() {
        (int, int) p1 = (10, 20);

        Console.WriteLine(p1);
        Console.WriteLine(p1 is (10, 20));
        Console.WriteLine();

        Console.WriteLine(GetAverageCelsiusTemperature(Season.Fall, true));

        int GetAverageCelsiusTemperature(Season season, bool daytime) => (season, daytime) switch {
            (Season.Spring, true) => 20,
            (Season.Spring, false) => 16,
            (Season.Summer, true) => 27,
            (Season.Summer, false) => 22,
            (Season.Fall, true) => 18,
            (Season.Fall, false) => 12,
            (Season.Winter, true) => 10,
            (Season.Winter, false) => -2,
            _ => throw new Exception("Unexpected combination")
        };
    }

    enum Season {
        Spring,
        Summer,
        Fall,
        Winter
    }
}