namespace Basics.Strings;

public class ManipulatingStrings {
    public static void UserMain() {
        string original = "0123456789";

        {
            string s1 = original.Substring(1, 5);
            string s2 = original.Substring(5);
            Console.WriteLine(original);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();
        }

        {
            string s1 = original.Insert(1, "Diego");
            Console.WriteLine(s1);
            Console.WriteLine();
        }

        {
            string s1 = original.Remove(1,5);
            Console.WriteLine(s1);
            Console.WriteLine();
        }

        {
            string s1 = original.PadLeft(original.Length + 5, '*');
            Console.WriteLine(s1);
            Console.WriteLine();
        }

        {
            string s1 = original.Replace('8', '#');
            Console.WriteLine(s1);
        }
    }
}