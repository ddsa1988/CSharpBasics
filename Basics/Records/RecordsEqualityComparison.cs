namespace Basics.Records;

public class RecordsEqualityComparison {
    public static void UserMain() {
        Points p1 = new Points(2, 3, 4);
        Console.WriteLine(p1);

        Console.WriteLine();

        Points p2 = p1 with { Z = 10 };
        Console.WriteLine(p2);

        Console.WriteLine();
        Console.WriteLine(p1.Equals(p2));
    }

    private record Points {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }

        public Points(double x, double y, double z) => (X, Y, Z) = (x, y, z);

        public override int GetHashCode() => X.GetHashCode() + Y.GetHashCode();

        public virtual bool Equals(Points? other) => other != null && X == other.X && Y == other.Y;
    }
}