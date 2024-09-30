namespace Basics.NumericalSystem.Examples;

public class Example002 {
    public static void UserMain() {
        {
            int a = int.MaxValue;

            Console.WriteLine($"Value of 'a' => {a}.");

            a++;
            Console.WriteLine($"Value of 'a' with overflow => {a}");
        }

        Console.WriteLine();

        {
            checked {
                try {
                    int a = int.MaxValue;

                    Console.WriteLine($"Value of 'a' => {a}.");

                    a++;
                    Console.WriteLine($"Value of 'a' with overflow => {a}");
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}