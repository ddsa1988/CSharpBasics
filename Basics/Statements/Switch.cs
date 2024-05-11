namespace Basics.Statements;

public class Switch {
    public static void Statement() {
        Console.Write("Type an card number from 1 up to 13: ");
        string? userInput = Console.ReadLine();

        bool isUserInputValid = int.TryParse(userInput, out int number);

        if (!isUserInputValid) {
            Console.WriteLine("Invalid number!");
            return;
        }

        switch (number) {
            case 13:
                Console.WriteLine("King");
                break;
            case 12:
                Console.WriteLine("Queen");
                break;
            case 11:
                Console.WriteLine("Jack");
                break;
            case -1:
                goto case 12;
            default:
                Console.WriteLine(number);
                break;
        }
    }

    public static void Expression() {
        Console.Write("Type a card number from 1 up 13: ");
        string? userInput = Console.ReadLine();

        bool conversionResult = int.TryParse(userInput, out int number);

        if (!conversionResult) {
            Console.WriteLine("Invalid number!");
            return;
        }

        string cardName = number switch {
            13 => "King",
            12 => "Queen",
            11 => "Joker",
            _ => number.ToString() //Equivalent to 'default'
        };

        Console.WriteLine(cardName);
    }

    public static void ExpressionWithTuples() {
        const int cardNumber = 13;
        const string cardSuit = "hearts";

        string card = (cardNumber, cardSuit) switch {
            (13, "diamonts") => "King os diamonts",
            (13, "spades") => "king of spades",
            (13, "hearts") => "King of hearts",
            (13, "clubs") => "King of clubs",
            _ => cardNumber.ToString() + " " + cardSuit.ToString(),
        };

        Console.WriteLine(card);
    }
}