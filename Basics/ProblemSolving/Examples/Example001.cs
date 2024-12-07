using Basics.ProblemSolving.Models;

namespace Basics.ProblemSolving.Examples;

public class Example001 {
    // Cards shuffle => we have one ordered deck of cards and we have to shuffle it in random order.
    public static void UserMain() {
        List<Card> cards = new List<Card>() {
            new() { Face = "7", Suit = Suit.Heart },
            new() { Face = "A", Suit = Suit.Spade },
            new() { Face = "10", Suit = Suit.Diamond },
            new() { Face = "2", Suit = Suit.Club },
            new() { Face = "6", Suit = Suit.Diamond },
            new() { Face = "J", Suit = Suit.Club },
        };

        PrintCards(cards);
        PerformingSingleSwap(cards);
    }

    private static void PrintCards(List<Card> cards) {
        Console.WriteLine(string.Join(" ", cards));
    }

    private static void PerformingSingleSwap(List<Card> cards) {
        ArgumentNullException.ThrowIfNull(cards);
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(cards.Count, 0);
    }
}