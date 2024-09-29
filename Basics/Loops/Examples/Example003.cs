namespace Basics.Loops.Examples;

public class Example003 {
    public static void UserMain() {
        const int number = 10;
        int counter = 0;

        while (counter < number) {
            Console.Write(counter + " ");
            counter++;
        }

        Console.WriteLine('\n');

        counter = 0;

        while (true) {
            Console.Write(counter + " ");
            counter++;

            if (counter < number) continue;

            break;
        }
    }
}