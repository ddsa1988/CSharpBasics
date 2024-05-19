namespace Basics.Structs;

public class Semantics {
    public static void UserMain() {
        // Point1 p1 = new Point1(); //Calls the parameterless constructor created by the user
        Point1 p1 = default; //Calls the implicit parameterless constructor
        Point1 p2 = new Point1(20, 30);
        
        Point2 p3 = default;
        Point2 p4 = new Point2(40, 60);

        Console.WriteLine("Struct Point1:\n");
        Console.WriteLine("p1.X => " + p1.X);
        Console.WriteLine("p1.Y => " + p1.Y);
        Console.WriteLine();

        Console.WriteLine("p2.X => " + p2.X);
        Console.WriteLine("p2.Y => " + p2.Y);
        Console.WriteLine();
        
        Console.WriteLine("Struct Point2:\n");
        Console.WriteLine("p3.X => " + p3.X);
        Console.WriteLine("p3.Y => " + p3.Y);
        Console.WriteLine();

        Console.WriteLine("p4.X => " + p4.X);
        Console.WriteLine("p4.Y => " + p4.Y);
    }

    private struct Point1 {
        public int X { get; set; }
        public int Y { get; set; }

        public Point1() {
            X = 5;
            Y = 10;
        }
        public Point1(int x, int y) {
            X = x;
            Y = y;
        }
    }

    private struct Point2 {
        private int x;
        private int y;

        public Point2(int x, int y) {
            X = x;
            Y = y;
        }

        public int X {
            get => x == 0 ? 5 : x;
            set => x = value;
        }

        public int Y {
            get => y == 0 ? 10 : y;
            set => y = value;
        }
    }
}