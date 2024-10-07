namespace Basics.UsingObjects.Exercises;

public class Exercise005 {
    // Write a program which by given two sides finds the hypotenuse of a right triangle. 
    // Implement entering of the lengths of the sides from the standard input, and for the  
    // calculation of the hypotenuse use methods of the class Math..
    public static void UserMain() {
        double sideA = GetTriangleSide(1);
        double sideB = GetTriangleSide(2);
        double hypotenuse = GetHypotenuse(sideA, sideB);

        Console.WriteLine("The triangle hypotenuse is {0:0.00}.", hypotenuse);
    }

    private static double GetTriangleSide(int sideIndex) {
        double number;

        while (true) {
            Console.Write($"Type the triangle {sideIndex} side: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = double.TryParse(userInput, out number);

            if (!isNumberValid) continue;

            break;
        }

        return number;
    }

    private static double GetHypotenuse(double sideA, double sideB) {
        double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

        return hypotenuse;
    }
}