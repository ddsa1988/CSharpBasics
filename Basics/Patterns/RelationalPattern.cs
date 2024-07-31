namespace Basics.Patterns;

public class RelationalPattern {
    public static void UserMain() {
        {
            const int n1 = 2;
            const int n2 = 5;

            if (n1 is < n2) Console.WriteLine($"{n1} is < {n2}");
        }

        Console.WriteLine();

        {
            int ibm = 22;

            string GetWeightCategory(decimal ibm) => ibm switch {
                < 18.5m => "underweight",
                < 25m => "normal",
                < 30 => "overweight",
                _ => "obese"
            };

            Console.WriteLine(GetWeightCategory(ibm));
        }

    }
}