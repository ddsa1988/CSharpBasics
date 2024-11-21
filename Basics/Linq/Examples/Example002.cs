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
        Console.WriteLine("Type => " + myCar.GetType().ToString());
    }
}