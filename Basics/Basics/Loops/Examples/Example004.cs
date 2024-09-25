namespace Basics.Loops.Examples;

public class Example004 {
    public static void UserMain() {
        const int number = 10;
        int counter = 0;

        do {
            Console.Write(counter + " ");
            counter++;
        } while (counter < number);

        Console.WriteLine('\n');

        counter = 0;

        do {
            Console.Write(counter + " ");
        } while (counter != 0);
    }
}