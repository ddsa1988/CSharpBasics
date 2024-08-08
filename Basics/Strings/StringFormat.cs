namespace Basics.Strings;

public class StringFormat {
    public static void UserMain() {
        {
            string composite = "Its' {0} degrees in {1} on this {2} morning .";
            string s1 = string.Format(composite, 32, "Perth", DateTime.Now.DayOfWeek);

            Console.WriteLine(s1);
        }

        Console.WriteLine();

        {
            string composite = "Name = {0, -20} Credit Limit = {1, 15:C}";
            string s1 = string.Format(composite, "Diego", 500);
            string s2 = string.Format(composite, "Amanda", 2000);

            string s3 = "Name = " + "Mary".PadRight(20) + " Credit Limit = " + 500.ToString("C").PadLeft(15);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}