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
                ShowEvaluateBandMenu();
                break;
            case 4:
                ShowAvgScoreMenu();
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
            isBandNameValid = TryGetBandName(out bandName);
        } while (!isBandNameValid);

        DataModel.AddItem(bandName);

        Console.WriteLine($"The Band {bandName} was registered...");
        Thread.Sleep(2000);
    }

    private static void ShowBandListMenu() {
        Console.Clear();
        ShowTitle("Bands Registered");

        DataModel.PrintItemsKeys();
        Console.WriteLine();
        WaitKeyPressed();
    }

    private static void ShowEvaluateBandMenu() {
        string? bandName;
        bool isBandNameValid;

        do {
            Console.Clear();
            ShowTitle("Evaluate Band");
            isBandNameValid = TryGetBandName(out bandName);
        } while (!isBandNameValid);

        if (DataModel.ListContainsKey(bandName)) {
            Console.WriteLine("Band is in the lis.");
        } else {
            Console.WriteLine("There is no band with this name in the list.");
        }

        WaitKeyPressed();
    }

    private static void ShowAvgScoreMenu() {
        Console.Clear();
        ShowTitle("Average Scores From Bands");

        DataModel.PrintItemsValues();
        Console.WriteLine();
        WaitKeyPressed();
    }

    private static bool TryGetBandName(out string? bandName) {
        Console.Write("Type the band name: ");
        bandName = Console.ReadLine();

        return !(string.IsNullOrEmpty(bandName) || string.IsNullOrWhiteSpace(bandName));
    }

    private static void WaitKeyPressed() {
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
}