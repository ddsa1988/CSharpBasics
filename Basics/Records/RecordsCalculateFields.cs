namespace Basics.Records;

public class RecordsCalculateFields {
    public static void UserMain() {
        Points p1 = new Points(2, 3);
        Console.WriteLine(p1);

        Console.WriteLine();

        Points p2 = p1 with { Y = 4 };
        Console.WriteLine(p2);

        Console.WriteLine();
        Console.WriteLine(p1.Equals(p2));
    }

    private record Points {
        private double _x;
        private double _y;
        private double? _distance;

        public Points(double x, double y) => (X, Y) = (x, y);

        public double X {
            get => _x;
            init {
                _x = value;
                _distance = null;
            }
        }

        public double Y {
            get => _y;
            init {
                _y = value;
                _distance = null;
            }
        }

        public double DistanceFromOrigin {
            get {
                _distance ??= Math.Sqrt((X * X) + (Y * Y));

                return _distance.Value;
            }
        }
    }
}