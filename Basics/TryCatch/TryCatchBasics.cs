namespace Basics.TryCatch;

public class TryCatchBasics {
    public static void UserMain() {

        {
            int n1 = 20;
            int n2 = 0;

            try {
                Console.Write("{0} / {1} = ", n1, n2);
                int result = n1 / n2;
                Console.Write(result);
            } catch (Exception e) {
                Console.WriteLine("\nCatch block is executed when an error occurs: " + e.Message);
            } finally {
                Console.WriteLine("Finally block is always executed.");
            }

            Console.WriteLine("Program finished.");
        }

        Console.WriteLine();

        try {
            int n1 = 20;
            int n2 = 10;

            Console.Write("{0} / {1} = ", n1, n2);
            int result = n1 / n2;
            Console.Write(result);
        } catch (Exception e) {
            Console.WriteLine("\nCatch block is executed when an error occurs: " + e.Message);
        } finally {
            Console.WriteLine("\nFinally block is always executed.");
        }

        Console.WriteLine("Program finished.");
    }
}