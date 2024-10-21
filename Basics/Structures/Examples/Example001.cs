using Basics.Structures.Models;

namespace Basics.Structures.Examples;

public class Example001 {
    // Structures are value types
    public static void UserMain() {
        Point2D p1 = new Point2D(10, 20);

        Console.WriteLine(p1);
        TryToChangePoint(p1);
        Console.WriteLine(p1);
    }

    private static void TryToChangePoint(Point2D p) {
        p.X++;
        p.Y++;
    }
}