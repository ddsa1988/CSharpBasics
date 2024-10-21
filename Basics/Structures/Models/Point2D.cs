namespace Basics.Structures.Models;

public struct Point2D {
    private double x;
    private double y;

    public Point2D(double x, double y) {
        X = x;
        Y = y;
    }

    public double X {
        get { return x; }
        set { x = value; }
    }

    public double Y {
        get { return y; }
        set { y = value; }
    }

    public override string ToString() {
        return $"X = {X}, Y = {Y}";
    }
}