namespace Basics.Structs;

public class Semantics {

    public struct Point {
        public int x;
        public int y;

        public Point() { }

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }

    public static void UserMain() {
        Point p1 = new Point();
        Point p2 = new Point(10,20);

        Console.WriteLine("p1.x => " + p1.x);
        Console.WriteLine("p1.y => " + p1.y);
        Console.WriteLine();

        Console.WriteLine("p2.x => " + p2.x);
        Console.WriteLine("p2.y => " + p2.y);
    }
}