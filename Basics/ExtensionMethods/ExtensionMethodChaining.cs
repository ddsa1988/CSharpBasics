namespace Basics.ExtensionMethods;

public class ExtensionMethodChaining {
    public static void UserMain() {
        Console.WriteLine("diego".AddSpace().Capitalize());
    }
}

public static class StringHelper2 {
    public static string AddSpace(this string str) {
        if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str)) return string.Empty;

        StringBuilder sb = new StringBuilder();

        foreach (char c in str) {
            sb.Append(c + " ");
        }

        return sb.ToString();
    }

    public static string Capitalize(this string str) {
        if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str)) return string.Empty;

        StringBuilder sb = new StringBuilder();
        int size = str.Length;


        sb.Append(char.ToUpper(str[0]));


        for (int i = 1; i < size; i++) {
            sb.Append(str[i]);
        }

        return sb.ToString();
    }
}