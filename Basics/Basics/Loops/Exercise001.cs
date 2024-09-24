namespace Basics.Loops;

public class Exercise001 {
    // Write a program that prints all possible cards from a standard deck
    // of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
    public static void UserMain() {
        string[] suits = ["Diamonds", "Spades", "Hearts", "Clubs"];
        string[] cards =
            ["Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"];

        int counter = 0;

        foreach (string suit in suits) {
            Console.Write(suit + " => ");
            foreach (string card in cards) {
                Console.Write(card + " ");
                counter++;
            }

            Console.WriteLine();
        }

        Console.WriteLine($"\nTotal of cards: {counter}.");
    }
}