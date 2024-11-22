namespace Basics.Linq.Examples;

public class Example002 {
    // Anonymous types
    public static void UserMain() {
        var myCar = new { Color = "Red", Brand = "BMW", Speed = 180 };

        Console.WriteLine("My car is {0} {1}.", myCar.Color, myCar.Brand);
        Console.WriteLine("It runs {0} km/h.", myCar.Speed);
        Console.WriteLine();

        Console.WriteLine("ToString => " + myCar);
        Console.WriteLine("HashCode => " + myCar.GetHashCode());
        Console.WriteLine("Equals? => " + myCar.Equals(new { Color = "Red", Brand = "BMW", Speed = 180 }));
        Console.WriteLine("Type => " + myCar.GetType());
        Console.WriteLine();

        var arr = new[] {
            new { X = 3, Y = 5 },
            new { X = 4, Y = 6 },
            new { X = 5, Y = 7 },
        };

        foreach (var item in arr) {
            Console.WriteLine(item);
        }
    }
}