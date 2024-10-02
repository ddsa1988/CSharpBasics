using System.Net;

namespace Basics.Methods.Examples;

public class Example004 {
    public static void UserMain() {
        const float illValue = 37;
        float fahrenheit;

        while (true) {
            Console.Write("Type a fahrenheit temperature: ");
            string? userInput = Console.ReadLine();

            bool isTempValid = float.TryParse(userInput, out fahrenheit);

            if (!isTempValid) continue;

            break;
        }

        float celsius = FahrenheitToCelsius(fahrenheit);

        Console.WriteLine("Your body temperature in Celsius degrees is {0:F2}.", celsius);

        if (celsius <= illValue) return;

        Console.WriteLine("You are ill.");
    }

    private static float FahrenheitToCelsius(float f) {
        float celsius = (f - 32f) * (5 / 9f);

        return celsius;
    }
}