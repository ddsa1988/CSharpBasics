namespace Basics.Expressions;

public class Exercise007 {
    /*
        We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on
        the position p has the value of v. Example: n = 35, p = 5, v = 0 -> n = 3. Another example: n = 35, p = 2, v = 1 -> n = 39. 
    */
    public static void UserMain() {
        int n = 35;
        int p = 5;
        int v = 0;
        int maskForOne = 1 << p;
        int maskForZero = ~(1 << p);

        int result = v == 1 ? n | maskForOne : n & maskForZero;

        Console.WriteLine(result);
    }
}