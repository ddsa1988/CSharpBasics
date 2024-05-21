namespace FavoriteBands;

public class Program {
    public static void Main(string[] args) {
        int userOption = 0;

        do {
            Screens.ShowMainMenu();
            userOption = UserInput.GetUserOption();
            Screens.SelectMenu(userOption);
        } while (userOption != 0);
    }
}