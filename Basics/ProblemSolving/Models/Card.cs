namespace Basics.ProblemSolving.Models;
public class Card {
    public string Face { get; set; } = string.Empty;
    public Suit Suit { get; set; }

    public override string ToString() {
        string card = "(" + Face + " " + Suit + ")";
        return card;
    }
}
