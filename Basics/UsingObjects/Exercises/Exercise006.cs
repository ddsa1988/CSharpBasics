namespace Basics.UsingObjects.Exercises;

public class Exercise006 {
    // Write a program which calculates the area of a triangle with the following given: three sides;
    // side and the altitude to it; two sides and the angle between them in degrees.
    public static void UserMain() {
        Console.WriteLine("{0:F2}", TriangleAreaThreeSides(9, 7, 14));
        Console.WriteLine("{0:F2}", TriangleAreaTwoSides(2, 4, 30));
        Console.WriteLine("{0:F2}", TriangleAreaOneSide(8, 7));
    }

    private static double TriangleAreaThreeSides(double a, double b, double c) {
        if (a < 0 || b < 0 || c < 0) throw new ArgumentException("Parameters must be positive.");

        double p = (a + b + c) / 2f;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        return area;
    }

    private static double TriangleAreaTwoSides(double a, double b, double degrees) {
        if (a < 0 || b < 0 || degrees < 0) throw new ArgumentException("Parameters must be positive.");

        double radians = Math.PI * degrees / 180;

        double area = 1 / 2f * a * b * Math.Sin(radians);
        return area;
    }

    private static double TriangleAreaOneSide(double a, double height) {
        if (a < 0 || height < 0) throw new ArgumentException("Parameters must be positive.");

        double area = a * height / 2f;
        return area;
    }
}