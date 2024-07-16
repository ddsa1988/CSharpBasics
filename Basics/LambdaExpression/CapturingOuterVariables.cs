namespace Basics.LambdaExpression;

public class CapturingOuterVariables {
    public static void UserMain() {
        int n1 = 10;

        {
            int factor = 1;

            Func<int, int> multiplier = a => a * factor;

            factor *= 2;
            Console.WriteLine(multiplier(n1));

            factor *= 2;
            Console.WriteLine(multiplier(n1));
        }

        Console.WriteLine();

        {
            int factor = 1;

            Func<int, int> multiplier = a => {
                factor *= 2; //Lambda expressions can themselves update captured variables
                return a * factor;
            };

            Console.WriteLine(multiplier(n1));
            Console.WriteLine(multiplier(n1));
        }

    }
}