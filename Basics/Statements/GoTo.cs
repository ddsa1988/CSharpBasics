namespace Basics.Statements;

public class GoTo {
    public static void UserMain() {
        const int startCount = 0;
        const int endCount = 10;
        const int exitValue = 5;

        for (int i = startCount; i < endCount; i++) {
            for (int j = startCount; j < endCount; j++) {
                Console.WriteLine(i + " " + j);

                if (j == exitValue) goto LoopEnd;
            }
        }

        LoopEnd:
        Console.WriteLine();

        int k = startCount;
        startLoop:

        if (k < endCount) {
            Console.Write(k + " ");

            k++;
            goto startLoop;
        }
    }
}