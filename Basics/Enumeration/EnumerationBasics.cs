namespace Basics.Enumeration;

public class EnumerationBasics {
    public static void UserMain() {
        const string s1 = "Diego";

        using CharEnumerator enumerator = s1.GetEnumerator();
        while (enumerator.MoveNext()) {
            char element = enumerator.Current;
            Console.Write(element + " ");
        }
    }
}