using System.Text.RegularExpressions;

namespace Basics.Strings.Exercises;

public class Exercise003 {
    // Write a program that checks whether the parentheses are placed correctly in an arithmetic expression. Example of expression with
    // correctly placed brackets: ((a+b)/5-d). Example of an incorrect expression: )(a+b)).
    public static void UserMain() {
        string sample1 = "((a+b)/5-d)";
        string sample2 = ")(a+b))";

        Console.WriteLine(IsParenthesesPlacedCorrectly(sample1));
        Console.WriteLine(IsParenthesesPlacedCorrectly(sample2));
    }

    private static bool IsParenthesesPlacedCorrectly(string expression) {
        if (string.IsNullOrEmpty(expression) || string.IsNullOrWhiteSpace(expression)) {
            throw new ArgumentException("Value is empty", nameof(expression));
        }

        const char openParentheses = '(';
        const char closeParentheses = ')';

        int counter = 0;

        foreach (char value in expression) {
            counter = value == openParentheses ? ++counter : value == closeParentheses ? --counter : counter;
        }

        return counter == 0;
    }
}