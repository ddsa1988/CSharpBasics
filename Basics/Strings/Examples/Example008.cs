namespace Basics.Strings.Examples;

public class Example008 {
    public static void UserMain() {
        {
            const string sample = "       diego        ";
            string trim = sample.Trim();

            Console.WriteLine("***" + sample + "***");
            Console.WriteLine("***" + trim + "***");
        }

        Console.WriteLine();

        {
            const string sample = "    111  $  %   diego   #  %      ";
            char[] trimChars = [' ', '1', '$', '%', '#', 's'];
            string trim = sample.Trim(trimChars);

            Console.WriteLine("***" + sample + "***");
            Console.WriteLine("***" + trim + "***");
        }
    }
}