namespace Basics.ExceptionHandling.Examples;

public class Example002 {
    public static void UserMain() {
        Exception e = new Exception("There was a problem.");

        throw e;
    }
}