namespace Basics.Classes;

public class MethodOverload {
    public static void UserMain() {
        const int iValue1 = 10;
        const int iValue2 = 20;

        const float fValue1 = 10.5F;
        const float fValue2 = 20.5F;

        const double dValue1 = 11.5;
        const double dValue2 = 21.5;

        Console.WriteLine($"{iValue1} int + {iValue2} int = {Sum(iValue1, iValue2)} int");
        Console.WriteLine($"{fValue1} float + {fValue2} float = {Sum(fValue1, fValue2)} float");
        Console.WriteLine($"{dValue1} double + {dValue2} double = {Sum(dValue1, dValue2)} double");
    }

    private static int Sum(int a, int b) => a + b;
    private static float Sum(float a, float b) => a + b;
    private static double Sum(double a, double b) => a + b;
}