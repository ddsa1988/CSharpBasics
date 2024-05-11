namespace Basics.Statements;

public class Continue {
    public static void UserMain() {
        const int startCount = 0;
        const int endCount = 10;

        for (int i = startCount; i < endCount; i++) {
            
            if(i % 2 == 0) continue;
            
            Console.Write(i + " ");
        }
    }
}