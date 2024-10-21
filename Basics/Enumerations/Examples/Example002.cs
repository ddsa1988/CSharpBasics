using Basics.Enumerations.Enums;
using Basics.Enumerations.Models;

namespace Basics.Enumerations.Examples;

public class Example002 {
    public static void UserMain() {
        Coffee smallCoffee = new Coffee(CoffeeSize.Small);
        Coffee mediumCoffee = new Coffee(CoffeeSize.Medium);
        Coffee largeCoffee = new Coffee(CoffeeSize.Large);

        Console.WriteLine($"The {smallCoffee.Size} coffee is {(int)smallCoffee.Size} ml.");
        Console.WriteLine($"The {mediumCoffee.Size} coffee is {(int)mediumCoffee.Size} ml.");
        Console.WriteLine($"The {largeCoffee.Size} coffee is {(int)largeCoffee.Size} ml.");
    }
}