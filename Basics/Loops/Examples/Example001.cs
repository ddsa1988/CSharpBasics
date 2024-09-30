namespace Basics.Loops.Examples;

public class Example001 {
    public static void UserMain() {
        const int number = 10;
        const int exitLoop = 5;

        for (int i = 0; i < number; i++) {
            Console.Write(i + " ");
        }

        Console.WriteLine('\n');

        for (int i = number; i >= 0; i--) {
            Console.Write(i + " ");
        }

        Console.WriteLine('\n');

        for (int i = 0; i < number; i++) {
            if (i == exitLoop) break;

            Console.Write(i + " ");
        }

        Console.WriteLine('\n');

        for (int i = 0; i < number; i++) {
            for (int j = 0; j < number; j++) {
                if (j == exitLoop) goto Exit;

                Console.Write(i + j + " ");
            }
        }
    Exit:
        Console.WriteLine();
    }
}