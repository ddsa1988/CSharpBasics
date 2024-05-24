namespace Basics.Enums;

public class EnumBasics {
    public static void UserMain() {
        Console.WriteLine($"Directions.{Directions.Left} => {(int)Directions.Left}");
        Console.WriteLine($"Directions.{Directions.Right} => {(int)Directions.Right}");
        Console.WriteLine($"Directions.{Directions.Up} => {(int)Directions.Up}");
        Console.WriteLine($"Directions.{Directions.Down} => {(int)Directions.Down}");
        Console.WriteLine();

        Directions myDirection = Directions.Left;
        Directions yourDirection = Directions.Left;

        Console.WriteLine(myDirection == yourDirection);

        myDirection = Directions.Right;
        yourDirection = Directions.Up;

        Console.WriteLine(myDirection);
        Console.WriteLine(yourDirection);
    }

    private enum Directions {
        Left,
        Right,
        Up,
        Down
    }

    private enum Weekdays : byte {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursdays = 5,
        Friday = 6,
        Saturday = 7
    }
}