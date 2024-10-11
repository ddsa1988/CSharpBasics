namespace Basics.Strings.Exercises;

public class Exercise003 {
    /* 
        Write a program that detects how many times a substring is contained in the text. 
        For example, let’s look for the substring "in" in the text:

        We are living in a yellow submarine. We don't have anything
        else. Inside the submarine is very tight. So we are drinking
        all the day. We will move out of it in 5 days.

        The result is 9 occurrences.
    */
    public static void UserMain() {
        string sample = """
            We are living in a yellow submarine. We don't have anything
            else. Inside the submarine is very tight. So we are drinking
            all the day. We will move out of it in 5 days.
        """;

        string substring = "in";

        Console.WriteLine(CountOccurrences(sample, substring));
    }

    private static int CountOccurrences(string text, string substring) {
        return 0;
    }
}