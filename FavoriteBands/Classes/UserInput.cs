namespace FavoriteBands.Classes;

public class UserInput {
    public static int GetUserOption() {
        string? userInput;
        int userOption;

        do {
            Console.Write("Type an option: ");
            userInput = Console.ReadLine();
        } while (!IsUserOptionValid(userInput, out userOption));

        return userOption;
    }

    private static bool IsUserOptionValid(string? userInput, out int userOption) {
        bool isOptionValid = int.TryParse(userInput, out int result);
        userOption = result;

        return isOptionValid;
    }

    private static string? GetUserBandName() {
        string? bandName;
        bool isBandNameValid;

        do {
            bandName = Console.ReadLine();
            isBandNameValid = !(string.IsNullOrEmpty(bandName) || string.IsNullOrWhiteSpace(bandName));
        } while (!isBandNameValid);

        return bandName;
    }
}