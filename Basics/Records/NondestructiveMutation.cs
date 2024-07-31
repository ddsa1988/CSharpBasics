namespace Basics.Records;

public class NondestructiveMutation {
    public static void UserMain() {
        Points p1 = new Points(10, 20);
        Points p2 = p1 with { Y = 50 };

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }

    private record Points {
        private double _x;
        private double _y;

        public Points(double x, double y) => (X, Y) = (x, y);

        public double X {
            get => _x;
            init {
                if (double.IsNaN(value)) {
                    throw new ArgumentException("X cannot be NaN");
                }
                _x = value;
            }
        }

        public double Y {
            get => _y;
            init {
                if (double.IsNaN(value)) {
                    throw new ArgumentException("Y cannot be NaN");
                }
                _y = value;
            }
        }
    }
}