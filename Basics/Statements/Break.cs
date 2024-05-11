namespace Basics.Statements;

public class Break {
    public static void UserMain() {
        const int startCount = 0;
        const int endCount = 10;
        const int exitValue = 5;
        
        for (int i = startCount; i < endCount; i++) {
            Console.Write(i + " ");

            if (i == exitValue) break;
        }
    }
}