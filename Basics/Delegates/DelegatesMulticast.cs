namespace Basics.Delegates;

public class DelegatesMulticast {
    public static void UserMain() {
        //Transformer t = Sum;
        //t += Power;
        //Console.WriteLine(t(10));

        ProgessReport p = WriteProgressToConsole;
        p += WriteProgressToFile;
        HardWork(p);
    }

    private delegate void ProgessReport(int percentComplete);

    private static void HardWork(ProgessReport p) {
        for (int i = 0; i < 10; i++) {
            p(i * 10);
            Thread.Sleep(100);
        }
    }

    private static void WriteProgressToConsole(int percentComplete) => Console.WriteLine(percentComplete);

    private static void WriteProgressToFile(int percentComplete) => File.WriteAllText("progress.txt", percentComplete.ToString());

    private delegate int Transformer(int x);

    private static int Sum(int a) {
        return a + a;
    }

    private static int Power(int a) {
        return a * a;
    }
}