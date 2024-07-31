using System.Windows.Markup;

namespace Basics.Patterns;

public class VarPattern {
    public static void UserMain() {
        Console.WriteLine(IsJaneOrJohnEx1("john"));
        Console.WriteLine(IsJaneOrJohnEx2("jAnE"));

    }

    private static bool IsJaneOrJohnEx1(string name) => name.ToUpper() is var upper && (upper.Equals("JANE") || upper.Equals("JOHN"));

    private static bool IsJaneOrJohnEx2(string name) {
        string upper = name.ToUpper();
        bool result = upper.Equals("JANE") || upper.Equals("JOHN");

        return result;
    }
}