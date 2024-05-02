namespace Basics.Parameters;
public class PassingArgumentsWithOut {
    public static void UserMain() {
        Console.WriteLine("Passing arguments by reference (out modifier):\n");
        Console.WriteLine("The out modifier is most commonly used to get multiple return values back from a method.\n");

        const string fullName = "Diego dos Santos Alexandre";

        SplitName(fullName, out string firstName, out string lastName);

        Console.WriteLine("Full name = {0}, First Name: {1}, Last Name: {2}.", fullName, firstName, lastName);

    }

    private static void SplitName(string fullName, out string firstName, out string lastName) {
        firstName = lastName = string.Empty;

        if (!fullName.Contains(' ')) {
            firstName = fullName;
            return;
        }

        int firstNameIndex = fullName.IndexOf(' ');
        int lastNameIndex = fullName.LastIndexOf(' ');

        firstName = fullName.Substring(0, firstNameIndex);
        lastName = fullName.Substring(lastNameIndex + 1);
    }
}

