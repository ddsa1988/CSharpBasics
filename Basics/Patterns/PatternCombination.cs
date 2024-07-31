namespace Basics.Patterns;

public class PatternCombination {
    public static void UserMain() {
        Console.WriteLine(IsBetween1And9(1));
        Console.WriteLine(IsVowel('U'));
        Console.WriteLine(IsLetter('Y'));
    }

    //private static bool IsBetween1And9(int n) => n >= 0 && n <= 9;
    private static bool IsBetween1And9(int n) => n is >= 0 and <= 9;

    private static bool IsVowel(char c) => char.ToLower(c) is 'a' or 'e' or 'i' or 'o' or 'u';

    private static bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'z';
}