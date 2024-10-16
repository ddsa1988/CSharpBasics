namespace Basics.Strings.Exercises;

public class Exercise016 {
    // Write a program that extracts from a text all words which are palindromes, such as ABBA", "lamal", "exe".
    public static void UserMain() {
        Console.WriteLine(IsPalindrome("ABBA"));
        Console.WriteLine(IsPalindrome("lamal"));
        Console.WriteLine(IsPalindrome("exe"));
        Console.WriteLine(IsPalindrome("diego"));
        Console.WriteLine(IsPalindrome("ABCDBA"));
    }

    private static bool IsPalindrome(string word) {
        if (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word)) return false;

        int Length = word.Length;
        int mid = word.Length / 2;
        bool flag = true;

        for (int i = 0; i < mid; i++) {
            if (word[i] == word[Length - i - 1]) continue;

            flag = false;
            break;
        }

        return flag;
    }
}