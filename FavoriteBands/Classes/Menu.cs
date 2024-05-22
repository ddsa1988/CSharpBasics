namespace FavoriteBands.Classes;

public class Menu {
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

    public static int GetUserOption() {
        int userOption;
        bool isOptionValid;

        do {
            Console.Write("Type an option: ");
            string? userInput = Console.ReadLine();
            
            isOptionValid = int.TryParse(userInput, out userOption);
        } while (!isOptionValid);

        return userOption;
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
                ShowBandListMenu();
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
        string? bandName;
        bool isBandNameValid;

        do {
            Console.Clear();

            ShowTitle("Register Band");
            Console.Write("Type the band name: ");
            bandName = Console.ReadLine();

            isBandNameValid = !(string.IsNullOrEmpty(bandName) || string.IsNullOrWhiteSpace(bandName));
        } while (!isBandNameValid);

        DataModel.AddItem(bandName);

        Console.WriteLine($"The Band {bandName} was registered...");
        Thread.Sleep(2000);
    }

    private static void ShowBandListMenu() {
        Console.Clear();
        ShowTitle("Bands Registered");

        DataModel.ShowItems();
        Console.WriteLine();
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
}