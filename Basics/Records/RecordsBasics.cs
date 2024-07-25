namespace Basics.Records;

public class RecordsBasics {
    public static void UserMain() {
        Points p1 = new Points(10, 20);
        Points p2 = new Points(10, 20);

        Console.WriteLine(p1);
        Console.WriteLine(p1.Equals(p2));

        Console.WriteLine();

        Console.WriteLine(Points.Equals(p1, p2));
        Console.WriteLine(Points.ReferenceEquals(p1, p2));
    }

    private record Points {
        public double X { get; init; }
        public double Y { get; init; }

        public Points(double x, double y) => (X, Y) = (x, y);
    }
}