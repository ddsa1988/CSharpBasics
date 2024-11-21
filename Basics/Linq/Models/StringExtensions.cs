namespace Basics.Linq.Models;

public static class StringExtensions {
    public static int WordCount(this string str) {
        char[] separators = [' ', '.', '?', '!'];

        return str.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}