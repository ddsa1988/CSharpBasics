namespace FavoriteBands.Classes;

public class Screens {

    private static void Greeting() {
        Console.WriteLine("FAVORITE BANDS\n");
    }

    private static void ShowTitle(string title) {
        string specialChar = string.Empty.PadLeft(title.Length, '*');

        Console.WriteLine(specialChar);
        Console.WriteLine(title);
        Console.WriteLine(specialChar + "\n");
    }

    public static void ShowMainMenu() {
        Dictionary<int, string> menuOptions = new Dictionary<int, string>() {
            { 0, "Exit" },
            { 1, "Register band" },
            { 2, "Show all registered bands" },
            { 3, "Evaluate band" },
            { 4, "Show the average score from a band" }
        };

        Console.Clear();
        Greeting();
        ShowTitle("Main Menu");

        foreach (KeyValuePair<int, string> item in menuOptions) {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine();
    }

    public static void SelectMenu(int option) {
        switch (option) {
            case 0:
                Console.WriteLine("Exiting app...");
                break;
            case 1:
                RegisterBandMenu();
                break;
            case 2:
                Console.WriteLine("Selected " + option);
                break;
            case 3:
                Console.WriteLine("Selected " + option);
                break;
            case 4:
                Console.WriteLine("Selected " + option);
                break;
            default:
                ShowMainMenu();
                break;
        }
    }

    private static void RegisterBandMenu() {
        Console.Clear();
        ShowTitle("Register Band");
        Console.Write("Type the band name: ");
    }
}