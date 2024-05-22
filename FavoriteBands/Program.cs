namespace FavoriteBands;

public class Program {
    public static void Main(string[] args) {
        int userOption = 0;

        do {
            Menu.ShowMainMenu();
            userOption = Menu.GetUserOption();
            Menu.SelectMenu(userOption);
        } while (userOption != 0);
    }
}