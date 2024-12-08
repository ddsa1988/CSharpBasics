using Basics.ProblemSolving.Models;

namespace Basics.ProblemSolving.Examples;

public class Example001 {
    // Cards shuffle => we have one ordered deck of cards, and we have to shuffle it in random order.
    public static void UserMain() {
        var cards = new List<Card>() {
            new() { Face = "7", Suit = Suit.Heart },
            new() { Face = "A", Suit = Suit.Spade },
            new() { Face = "10", Suit = Suit.Diamond },
            new() { Face = "2", Suit = Suit.Club },
            new() { Face = "6", Suit = Suit.Diamond },
            new() { Face = "J", Suit = Suit.Club },
        };

        Console.WriteLine("Initial deck: ");
        PrintCards(cards);
        
        Console.WriteLine();
        ShuffleCards(cards);
        
        Console.WriteLine("Shuffled Deck: ");
        PrintCards(cards);
    }

    private static void PrintCards(List<Card> cards) {
        Console.WriteLine(string.Join(" ", cards));
    }

    private static void PerformingSingleSwap(List<Card> cards) {
        ArgumentNullException.ThrowIfNull(cards);
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(cards.Count, 0);

        int randomIndex = RandomNumber.GetNextInt(1, cards.Count - 1);

        Card firstCard = cards[0];
        Card randomCard = cards[randomIndex];

        cards[0] = randomCard;
        cards[randomIndex] = firstCard;
    }

    private static void ShuffleCards(List<Card> cards) {
        for (int i = 0; i < cards.Count - 1; i++) {
            PerformingSingleSwap(cards);
        }
    }
}