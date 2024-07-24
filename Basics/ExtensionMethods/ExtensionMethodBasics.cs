namespace Basics.ExtensionMethods;

/*
    Extension methods allow an existing type to be extended with new methods without
    altering the definition of the original type. An extension method is a static method
    of a static class, where the 'this' modifier is applied to the first parameter. The type
    of the first parameter will be the type that is extended
 */

public class ExtensionMethodBasics {
    public static void UserMain() {
        Console.WriteLine("Diego".IsCapitalized());
        Console.WriteLine("diego".IsCapitalized());
        Console.WriteLine("amanda".First());
    }
}

public static class StringHelper1 {
    public static bool IsCapitalized(this string str) {
        if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str)) return false;

        return char.IsUpper(str[0]);
    }

    public static T First<T>(this IEnumerable<T> sequence) {
        foreach (T item in sequence) {
            return item;
        }

        throw new InvalidOperationException();
    }
}