namespace Basics.Strings;

public class SplitAndJoinStrings {
    public static void UserMain() {

        SplitString("Diego dos.Santos,Alexandre");
        Console.WriteLine();
        SplitString("Diego dos Santos");
        Console.WriteLine();

        JoinString(new string[] { "Diego", "dos", "Santos", "Alexandre" }, " ");
        Console.WriteLine();
        JoinString(new string[] { "Diego", "dos", "Santos", "Alexandre" }, " ? ");
    }

    private static void SplitString(string str) {
        if (str == null) {
            Console.WriteLine("String must be not null.");
            return;
        }

        char[] separators = new char[] { ' ', '.', ',' };
        string[] strArray = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string s in strArray) {
            Console.WriteLine(s);
        }
    }

    private static void JoinString(string[] strArray, string seprator) {
        if (strArray == null) {
            Console.WriteLine("Array must be not null.");
            return;
        }

        if (seprator == null) {
            Console.WriteLine("Separator must be not null.");
            return;
        }

        string str = string.Join(seprator, strArray);
        Console.WriteLine(str);
    }
}